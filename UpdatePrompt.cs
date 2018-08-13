using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace PlenteumWallet
{
    public partial class UpdatePrompt : PlenteumWalletForm
    {
        public UpdatePrompt()
        {
            InitializeComponent();

            this.Text = Application.ProductName;
        }

        private void UpdatePrompt_Load(object sender, EventArgs e)
        {
            updateWorker.RunWorkerAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Utilities.CloseProgram(e);
        }

        private void UpdateRequest()
        {
            /*TODO: Fix Update */
            //try
            //{
            //    System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            //    string thisVersionString = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //    bool needsUpdate = false;
            //    var builtURL = "https://api.github.com/repos/turtlecoin/desktop-xamarin/releases/latest";

            //    var cli = new WebClient();
            //    cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            //    cli.Headers[HttpRequestHeader.UserAgent] = "Plenteum Wallet " + thisVersionString;
            //    string response = cli.DownloadString(new Uri(builtURL));

            //    var jobj = JObject.Parse(response);

            //    string gitVersionString = jobj["tag_name"].ToString();
               
            //    var gitVersion = new Version(gitVersionString);
            //    var thisVersion = new Version(thisVersionString);

            //    var result = gitVersion.CompareTo(thisVersion);
            //    if (result > 0)
            //    {
            //        needsUpdate = true;
            //    }
            //    else
            //    {
            //        needsUpdate = false;
            //    }

            //    if (needsUpdate)
            //    {
            //        foreach (var item in jobj["assets"])
            //        {
            //            string name = item["name"].ToString();
            //            if (name.Contains("PlenteumWallet.exe"))
            //            {
            //                DialogResult dialogResult = MessageBox.Show("A new version of Plenteum Wallet is out. Download?", "Plenteum Wallet", MessageBoxButtons.YesNo);
            //                if (dialogResult == DialogResult.No)
            //                {
            //                    return;
            //                }
            //                var dl = new WebClient();
            //                dl.Headers[HttpRequestHeader.UserAgent] = "Plenteum Wallet " + thisVersionString;
            //                dl.DownloadFile(item["browser_download_url"].ToString(), "PlenteumWallet_update.exe");
            //                System.Diagnostics.Process.Start("PlenteumWallet_update.exe");
            //                Environment.Exit(0);
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Failed to check for updates! " + ex.Message + Environment.NewLine + ex.InnerException, "Plenteum Wallet");
            //}
        }

        private void UpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Utilities.Close(this);
        }

        private void UpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (System.AppDomain.CurrentDomain.FriendlyName == "PlenteumWallet_update.exe")
                {
                    System.Threading.Thread.Sleep(500);
                    System.IO.File.Copy("PlenteumWallet_update.exe", "PlenteumWallet.exe", true);
                    System.Diagnostics.Process.Start("PlenteumWallet.exe");
                    Environment.Exit(0);
                }
                else if (System.AppDomain.CurrentDomain.FriendlyName == "PlenteumWallet.exe")
                {
                    if (System.IO.File.Exists("PlenteumWallet_update.exe"))
                    {
                        System.IO.File.Delete("PlenteumWallet_update.exe");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to check for updates!", "Plenteum Wallet");
            }

            UpdateRequest();
        }
    }

}
