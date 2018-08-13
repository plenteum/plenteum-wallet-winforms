using System;
using System.Windows.Forms;

namespace PlenteumWallet
{
    public partial class SelectionPrompt : PlenteumWalletForm
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

        public SelectionPrompt()
        {
            InitializeComponent();
            this.Text = Application.ProductName;
            //if(IsRunningOnMono())
            //{
            //    this.Width = this.Width + 150;
            //    this.Height = this.Height + 150;
            //}
        }        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Utilities.CloseProgram(e);
        }

        private void CreateWalletButton_Click(object sender, EventArgs e)
        {
            CreateWalletPrompt CWP = new CreateWalletPrompt();
            Utilities.Hide(this);
            var CWPreturn = CWP.ShowDialog();
            if (CWPreturn == DialogResult.OK)
            {
                WalletPath = CWP.WalletPath;
                WalletPassword = CWP.WalletPassword;
                Utilities.SetDialogResult(this, DialogResult.OK);
                Utilities.Close(CWP);
                Utilities.Close(this);
            }
            this.Show();
        }

        private void ImportWalletButton_Click(object sender, EventArgs e)
        {
            ImportWalletPrompt IWP = new ImportWalletPrompt();
            Utilities.Hide(this);
            var IWPreturn = IWP.ShowDialog();
            if (IWPreturn == DialogResult.OK)
            {
                WalletPath = IWP.ImportWalletPath;
                WalletPassword = IWP.ImportWalletPassword;
                Utilities.SetDialogResult(this, DialogResult.OK);
                Utilities.Close(IWP);
                Utilities.Close(this);
            }
            this.Show();
        }

        private void SelectWalletButton_Click(object sender, EventArgs e)
        {
            var curDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            OpenFileDialog findwalletdialog = new OpenFileDialog
            {
                InitialDirectory = curDir,
                Filter = "wallet files (*.wallet)|*.wallet|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (findwalletdialog.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(findwalletdialog.FileName))
                {
                    WalletPath = findwalletdialog.FileName;
                    var pPrompt = new PasswordPrompt();
                    Utilities.Hide(this);

                    var pResult = pPrompt.ShowDialog();
                    if (pResult != DialogResult.OK)
                    {
                        findwalletdialog.Dispose();
                        Utilities.Close(pPrompt);
                        this.Show();
                        return;
                    }
                    else
                    {
                        WalletPassword = pPrompt.WalletPassword;
                        Utilities.Close(pPrompt);
                        Utilities.SetDialogResult(this, DialogResult.OK);
                        Utilities.Close(this);
                    }
                }
            }
        }

        public static bool IsRunningOnMono()
        {
            return Type.GetType("Mono.Runtime") != null;
        }
    }
}
