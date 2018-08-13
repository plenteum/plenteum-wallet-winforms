namespace PlenteumWallet
{
    partial class PasswordPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createMainPanel = new System.Windows.Forms.Panel();
            this.walletPasswordLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.passwordConfirmTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new PlenteumWallet.PlenteumWalletLabelButton();
            this.createWalletButton = new PlenteumWallet.PlenteumWalletLabelButton();
            this.passwordLogo = new System.Windows.Forms.PictureBox();
            this.createMainPanel.SuspendLayout();
            this.createMainTable.SuspendLayout();
            this.passwordConfirmTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // createMainPanel
            // 
            this.createMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.createMainPanel.Controls.Add(this.walletPasswordLabel);
            this.createMainPanel.Controls.Add(this.welcomeLabel);
            this.createMainPanel.Controls.Add(this.createMainTable);
            this.createMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createMainPanel.Location = new System.Drawing.Point(0, 162);
            this.createMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.createMainPanel.Name = "createMainPanel";
            this.createMainPanel.Size = new System.Drawing.Size(500, 174);
            this.createMainPanel.TabIndex = 1;
            // 
            // walletPasswordLabel
            // 
            this.walletPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.walletPasswordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.walletPasswordLabel.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.walletPasswordLabel.Location = new System.Drawing.Point(0, 46);
            this.walletPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.walletPasswordLabel.Name = "walletPasswordLabel";
            this.walletPasswordLabel.Size = new System.Drawing.Size(500, 32);
            this.walletPasswordLabel.TabIndex = 98;
            this.walletPasswordLabel.Text = "Wallet Password:";
            this.walletPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(500, 46);
            this.welcomeLabel.TabIndex = 97;
            this.welcomeLabel.Text = "Welcome to Plenteum Wallet";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createMainTable
            // 
            this.createMainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.createMainTable.ColumnCount = 1;
            this.createMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.createMainTable.Controls.Add(this.passwordConfirmTable, 0, 0);
            this.createMainTable.Controls.Add(this.buttonsTable, 0, 1);
            this.createMainTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createMainTable.Location = new System.Drawing.Point(0, 79);
            this.createMainTable.Margin = new System.Windows.Forms.Padding(2);
            this.createMainTable.Name = "createMainTable";
            this.createMainTable.RowCount = 2;
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.02439F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.97561F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.createMainTable.Size = new System.Drawing.Size(500, 95);
            this.createMainTable.TabIndex = 0;
            // 
            // passwordConfirmTable
            // 
            this.passwordConfirmTable.ColumnCount = 2;
            this.passwordConfirmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.99662F));
            this.passwordConfirmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.00339F));
            this.passwordConfirmTable.Controls.Add(this.panel1, 1, 0);
            this.passwordConfirmTable.Controls.Add(this.panel2, 0, 0);
            this.passwordConfirmTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordConfirmTable.Location = new System.Drawing.Point(2, 2);
            this.passwordConfirmTable.Margin = new System.Windows.Forms.Padding(2);
            this.passwordConfirmTable.Name = "passwordConfirmTable";
            this.passwordConfirmTable.RowCount = 1;
            this.passwordConfirmTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passwordConfirmTable.Size = new System.Drawing.Size(496, 33);
            this.passwordConfirmTable.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(112, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 27);
            this.panel1.TabIndex = 100;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.White;
            this.passwordText.Location = new System.Drawing.Point(0, 0);
            this.passwordText.Margin = new System.Windows.Forms.Padding(2);
            this.passwordText.MaxLength = 150;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(381, 29);
            this.passwordText.TabIndex = 1;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 27);
            this.panel2.TabIndex = 101;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.passwordLabel.Location = new System.Drawing.Point(0, 0);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(103, 27);
            this.passwordLabel.TabIndex = 100;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonsTable
            // 
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.cancelButton, 1, 0);
            this.buttonsTable.Controls.Add(this.createWalletButton, 0, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTable.Location = new System.Drawing.Point(2, 39);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.buttonsTable.Size = new System.Drawing.Size(496, 54);
            this.buttonsTable.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.Location = new System.Drawing.Point(250, 4);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(244, 50);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // createWalletButton
            // 
            this.createWalletButton.AutoSize = true;
            this.createWalletButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.createWalletButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createWalletButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createWalletButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWalletButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createWalletButton.Location = new System.Drawing.Point(2, 4);
            this.createWalletButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.createWalletButton.Name = "createWalletButton";
            this.createWalletButton.Size = new System.Drawing.Size(244, 50);
            this.createWalletButton.TabIndex = 1;
            this.createWalletButton.Text = "Submit";
            this.createWalletButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createWalletButton.Click += new System.EventHandler(this.CreateWalletButton_Click);
            // 
            // passwordLogo
            // 
            this.passwordLogo.BackgroundImage = global::PlenteumWallet.Properties.Resources.ple_banner;
            this.passwordLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordLogo.Location = new System.Drawing.Point(0, 0);
            this.passwordLogo.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLogo.Name = "passwordLogo";
            this.passwordLogo.Size = new System.Drawing.Size(500, 162);
            this.passwordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordLogo.TabIndex = 0;
            this.passwordLogo.TabStop = false;
            // 
            // PasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 336);
            this.Controls.Add(this.createMainPanel);
            this.Controls.Add(this.passwordLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PasswordPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.createMainPanel.ResumeLayout(false);
            this.createMainTable.ResumeLayout(false);
            this.passwordConfirmTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.buttonsTable.ResumeLayout(false);
            this.buttonsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox passwordLogo;
        private System.Windows.Forms.Panel createMainPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TableLayoutPanel createMainTable;
        private System.Windows.Forms.Label walletPasswordLabel;
        private PlenteumWalletLabelButton cancelButton;
        private PlenteumWalletLabelButton createWalletButton;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.TableLayoutPanel passwordConfirmTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label passwordLabel;
    }
}
