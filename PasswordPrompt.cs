using System;
using System.Windows.Forms;

namespace PlenteumWallet
{
    public partial class PasswordPrompt : PlenteumWalletForm
    {
        public string WalletPassword { get; set; }

        public PasswordPrompt()
        {
            InitializeComponent();

            this.Text = Application.ProductName;

            walletPasswordLabel.Text = String.Format("{0} Wallet Password:", System.IO.Path.GetFileNameWithoutExtension(Properties.Settings.Default.walletPath));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Utilities.CloseProgram(e);
        }

        private void PasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (passwordText.Text != "" && passwordText.Text.Length > 6)
                {
                    WalletPassword = passwordText.Text;
                    Utilities.SetDialogResult(this, DialogResult.OK);
                    Utilities.Close(this);
                }
            }
        }        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Plenteum Wallet Cancel?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Utilities.Close(this);
            }
        }

        private void CreateWalletButton_Click(object sender, EventArgs e)
        {
            WalletPassword = passwordText.Text;
            Utilities.SetDialogResult(this, DialogResult.OK);
            Utilities.Close(this);
        }
    }
}
