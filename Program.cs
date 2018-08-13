using System;
using System.Windows.Forms;

namespace PlenteumWallet
{
    static class Program
    {
        public static bool jumpBack = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            Properties.Settings.Default.Reset();
#endif

            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var uPrompt = new UpdatePrompt();
            uPrompt.ShowDialog();

            string _pass = "";
            string _wallet = "";

            /* Reopen wallet from last time */
            if (Properties.Settings.Default.walletPath != "" && System.IO.File.Exists(Properties.Settings.Default.walletPath))
            {
                var pPrompt = new PasswordPrompt();
                var pResult = pPrompt.ShowDialog();
                if (pResult != DialogResult.OK)
                {
                    SelectionPrompt sPrompt = new SelectionPrompt();
                    sPrompt.ShowDialog();
                    if (sPrompt.DialogResult != DialogResult.OK)
                    {
                        return;
                    }
                    else
                    {
                        _pass = sPrompt.WalletPassword;
                        _wallet = sPrompt.WalletPath;
                    }
                }
                else
                {
                    _pass = pPrompt.WalletPassword;
                    _wallet = Properties.Settings.Default.walletPath;
                    Utilities.Close(pPrompt);
                }
            }
            else
            {
                SelectionPrompt sPrompt = new SelectionPrompt();
                sPrompt.ShowDialog();
                if (sPrompt.DialogResult != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    _pass = sPrompt.WalletPassword;
                    _wallet = sPrompt.WalletPath;
                }
            }

jumpBackFlag:
            var splash = new Splash(_wallet,_pass);
            Application.Run(splash);
            if (jumpBack) //Hacky, but will work for now until a proper loop can be placed.
            {
                jumpBack = false;
                goto jumpBackFlag;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }

    class NoBorderTabControl : TabControl
    {
        private const int TCM_ADJUSTRECT = 0x1328;

        protected override void WndProc(ref Message m)
        {
            // Hide the tab headers at run-time
            if (m.Msg == TCM_ADJUSTRECT && !DesignMode)
            {
                m.Result = (IntPtr)1;
                return;
            }

            // call the base class implementation
            base.WndProc(ref m);
        }
    }
}
