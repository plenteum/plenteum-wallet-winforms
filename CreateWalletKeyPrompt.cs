using System;
using System.Windows.Forms;

namespace PlenteumWallet
{
    public partial class CreateWalletKeyPrompt : PlenteumWalletForm
    {
        public CreateWalletKeyPrompt(string keyOutput)
        {
            InitializeComponent();
            KeysTextbox.Text = keyOutput;
            this.Text = Application.ProductName;
        }

        private void CreateWalletButton_Click(object sender, EventArgs e)
        {
            Utilities.Close(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Utilities.CloseProgram(e);
        }
    }
}
