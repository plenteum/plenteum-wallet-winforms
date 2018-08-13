using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PlenteumWallet
{
    public partial class Splash : PlenteumWalletForm
    {
        public string WalletPath { get; set; }

        public string WalletPassword { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Splash(string _wallet, string _password)
        {
            InitializeComponent();
            WalletPath = _wallet;
            WalletPassword = _password;
            versionLabel.Text = "v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = Application.ProductName;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Utilities.CloseProgram(e);
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            StatusLabel.Text = "Connecting to daemon ...";
            splashBackgroundWorker.RunWorkerAsync();
        }

        private void SplashBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int failcount = 0;
            string globalLastline = "";
            try
            {
                var connReturn = ConnectionManager.StartDaemon(WalletPath, WalletPassword);
                if (connReturn.Item1 == false)
                {
                    this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = "Daemon Connection Failed: " + connReturn.Item2; });

                    if (System.IO.File.Exists("service.log")) 
                    {
                        using (StreamReader sr = new StreamReader("service.log"))
                        {
                            string contents = sr.ReadToEnd();

                            if (contents.Contains("Internal error") || 
                                contents.Contains("Corruption: no meta-nextfile entry in descriptor"))
                            {
                                if (MessageBox.Show("Unfortunately, your blockchain has got corrupted. " +
                                                    "This can occur when you exit the GUI without saving or " +
                                                    "you lose power, among other reasons. You can fix this by " +
                                                    "resyncing your blockchain. Open a link on how to do this?",
                                                    "Plenteum Wallet",
                                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    System.Diagnostics.Process.Start("https://github.com/plenteum/plenteum/wiki/Bootstrapping-the-Blockchain");
                                }

                                throw new Exception("The GUI is unusable until this issue is fixed. It will now close.");
                            }
                        }
                    }

                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(3);
                }
               
                while (true)
                {
                    string lastLine = "";
                    bool lineWasUpdated = false;
                    if (System.IO.File.Exists("service.log"))
                    {
                        var fs = new FileStream("service.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using (var sr = new StreamReader(fs))
                        {
                            while (!sr.EndOfStream)
                            {
                                string linecache = sr.ReadLine();
                                if (String.IsNullOrWhiteSpace(linecache))
                                    break;

                                lastLine = linecache;

                                if (globalLastline == lastLine)
                                    lineWasUpdated = false;
                                else
                                    lineWasUpdated = true;

                                globalLastline = linecache;

                                if (lastLine.Contains("The password is wrong") || lastLine.Contains("Restored view public key doesn't correspond to secret key"))
                                {
                                    try
                                    {
                                        connReturn.Item3.CancelOutputRead();
                                        connReturn.Item3.Kill();
                                    }
                                    catch
                                    {
                                    }

                                    MessageBox.Show("The password is incorrect!", "Plenteum Wallet");
                                    //will restart at selection screen instead of exiting
                                    Program.jumpBack = true;
                                    break;
                                }
                            }
                        }
                        fs.Close();
                    }

                    try
                    {

                        if (lastLine.Contains("Imported block with index"))
                        {
                            string stdUpdate = lastLine.Split(new string[] { "    " }, StringSplitOptions.None)[1];
                            this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = stdUpdate; });
                            System.Threading.Thread.Sleep(3000);
                            continue;
                        }

                        if (Process.GetProcessesByName("service").Length < 1 || connReturn.Item3 == null)
                        {
                            throw new Exception("Daemon exited!");
                        }

                        var resp = ConnectionManager.Request("getStatus");
                        if (resp.Item1 == false)
                        {
                            throw new Exception("No RPC connection/Failed");
                        }

                        var block_count = (int)resp.Item3["blockCount"];
                        var known_block_count = (int)resp.Item3["knownBlockCount"];
                        if (known_block_count == 0)
                        {
                            this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = "Waiting on known block count..." ; });
                            continue;
                        }

                        this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = "Syncing... [" + block_count.ToString() + " / " + known_block_count.ToString() + "]"; });
                        if (known_block_count > 0 && (block_count >= known_block_count - 1))
                        {
                            this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = "Wallet is synced, opening..."; });
                            e.Result = connReturn.Item3;
                            break;
                        }

                    }
                    catch (Exception ex)
                    {
                        if (Process.GetProcessesByName("service").Length < 1 || connReturn.Item3 == null)
                        {
                            throw new Exception("Daemon exited!");
                        }
                        if (lineWasUpdated == false)
                        {
                            failcount += 1;
                            if (failcount >= 100)
                            {
                                throw new Exception("MAXTRYERROR: " + ex.Message);
                            }
                            this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = "Waiting on Daemon, trying..(" + failcount.ToString() + "/100)"; });
                        }
                        else
                        {
                            this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = "Waiting on Daemon to start sync..."; });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.StatusLabel.BeginInvoke((MethodInvoker)delegate () { this.StatusLabel.Text = "Daemon Connection Failed: " + ex.Message ; });
                MessageBox.Show("Daemon Connection Failed: " + ex.Message, "Plenteum Wallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(3);
            }
        }

        private void SplashBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void SplashBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Program.jumpBack)
            {
                Utilities.Close(this);
            }
            else
            {
                Utilities.Hide(this);
                var walletWindow = new Wallet(WalletPath, WalletPassword, (Process)e.Result);
                walletWindow.Closed += (s, args) => Utilities.Close(this);
                walletWindow.Show();
            }
        }
    }
}
