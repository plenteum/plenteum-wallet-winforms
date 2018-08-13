namespace PlenteumWallet
{
    partial class CreateWalletPrompt { 
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
            this.CreateLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createProgressbar = new System.Windows.Forms.ProgressBar();
            this.createMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.passwordConfirmTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.passwordConfirmLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.passwordConfirmText = new System.Windows.Forms.TextBox();
            this.passwordTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new PlenteumWallet.PlenteumWalletLabelButton();
            this.createWalletButton = new PlenteumWallet.PlenteumWalletLabelButton();
            this.walletNameTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.walletNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.walletNameText = new System.Windows.Forms.TextBox();
            this.createLogo = new System.Windows.Forms.PictureBox();
            this.createMainPanel.SuspendLayout();
            this.createMainTable.SuspendLayout();
            this.passwordConfirmTable.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.passwordTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            this.walletNameTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // createMainPanel
            // 
            this.createMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.createMainPanel.Controls.Add(this.CreateLabel);
            this.createMainPanel.Controls.Add(this.welcomeLabel);
            this.createMainPanel.Controls.Add(this.createProgressbar);
            this.createMainPanel.Controls.Add(this.createMainTable);
            this.createMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createMainPanel.Location = new System.Drawing.Point(0, 162);
            this.createMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.createMainPanel.Name = "createMainPanel";
            this.createMainPanel.Size = new System.Drawing.Size(448, 238);
            this.createMainPanel.TabIndex = 1;
            // 
            // CreateLabel
            // 
            this.CreateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CreateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateLabel.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.CreateLabel.Location = new System.Drawing.Point(0, 50);
            this.CreateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(448, 32);
            this.CreateLabel.TabIndex = 2;
            this.CreateLabel.Text = "Wallet Creation:";
            this.CreateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(0, 4);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(448, 46);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Plenteum Wallet";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createProgressbar
            // 
            this.createProgressbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.createProgressbar.ForeColor = System.Drawing.Color.Green;
            this.createProgressbar.Location = new System.Drawing.Point(0, 0);
            this.createProgressbar.Margin = new System.Windows.Forms.Padding(2);
            this.createProgressbar.Name = "createProgressbar";
            this.createProgressbar.Size = new System.Drawing.Size(448, 4);
            this.createProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.createProgressbar.TabIndex = 3;
            this.createProgressbar.Visible = false;
            // 
            // createMainTable
            // 
            this.createMainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.createMainTable.ColumnCount = 1;
            this.createMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.createMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.createMainTable.Controls.Add(this.passwordConfirmTable, 0, 2);
            this.createMainTable.Controls.Add(this.passwordTable, 0, 1);
            this.createMainTable.Controls.Add(this.buttonsTable, 0, 3);
            this.createMainTable.Controls.Add(this.walletNameTable, 0, 0);
            this.createMainTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createMainTable.Location = new System.Drawing.Point(0, 84);
            this.createMainTable.Margin = new System.Windows.Forms.Padding(2);
            this.createMainTable.Name = "createMainTable";
            this.createMainTable.RowCount = 4;
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.32332F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.32332F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.32332F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03003F));
            this.createMainTable.Size = new System.Drawing.Size(448, 154);
            this.createMainTable.TabIndex = 0;
            // 
            // passwordConfirmTable
            // 
            this.passwordConfirmTable.ColumnCount = 2;
            this.passwordConfirmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.passwordConfirmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.passwordConfirmTable.Controls.Add(this.panel5, 0, 0);
            this.passwordConfirmTable.Controls.Add(this.panel6, 1, 0);
            this.passwordConfirmTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordConfirmTable.Location = new System.Drawing.Point(2, 72);
            this.passwordConfirmTable.Margin = new System.Windows.Forms.Padding(2);
            this.passwordConfirmTable.Name = "passwordConfirmTable";
            this.passwordConfirmTable.RowCount = 1;
            this.passwordConfirmTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passwordConfirmTable.Size = new System.Drawing.Size(444, 31);
            this.passwordConfirmTable.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.passwordConfirmLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 25);
            this.panel5.TabIndex = 0;
            // 
            // passwordConfirmLabel
            // 
            this.passwordConfirmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.passwordConfirmLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordConfirmLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.passwordConfirmLabel.Location = new System.Drawing.Point(0, 0);
            this.passwordConfirmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.passwordConfirmLabel.Name = "passwordConfirmLabel";
            this.passwordConfirmLabel.Size = new System.Drawing.Size(171, 31);
            this.passwordConfirmLabel.TabIndex = 5;
            this.passwordConfirmLabel.Text = "Password Confirm:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.passwordConfirmText);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(180, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 25);
            this.panel6.TabIndex = 1;
            // 
            // passwordConfirmText
            // 
            this.passwordConfirmText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.passwordConfirmText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordConfirmText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordConfirmText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordConfirmText.ForeColor = System.Drawing.Color.White;
            this.passwordConfirmText.Location = new System.Drawing.Point(0, 0);
            this.passwordConfirmText.Margin = new System.Windows.Forms.Padding(2);
            this.passwordConfirmText.MaxLength = 150;
            this.passwordConfirmText.Name = "passwordConfirmText";
            this.passwordConfirmText.Size = new System.Drawing.Size(261, 29);
            this.passwordConfirmText.TabIndex = 7;
            this.passwordConfirmText.UseSystemPasswordChar = true;
            // 
            // passwordTable
            // 
            this.passwordTable.ColumnCount = 2;
            this.passwordTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.passwordTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.passwordTable.Controls.Add(this.panel3, 0, 0);
            this.passwordTable.Controls.Add(this.panel4, 1, 0);
            this.passwordTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTable.Location = new System.Drawing.Point(2, 37);
            this.passwordTable.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTable.Name = "passwordTable";
            this.passwordTable.RowCount = 1;
            this.passwordTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passwordTable.Size = new System.Drawing.Size(444, 31);
            this.passwordTable.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.passwordLabel);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 25);
            this.panel3.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.passwordLabel.Location = new System.Drawing.Point(0, 0);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(171, 31);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.passwordText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(180, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 25);
            this.panel4.TabIndex = 1;
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
            this.passwordText.MaxLength = 151;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(261, 29);
            this.passwordText.TabIndex = 6;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // buttonsTable
            // 
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.cancelButton, 1, 0);
            this.buttonsTable.Controls.Add(this.createWalletButton, 0, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTable.Location = new System.Drawing.Point(2, 107);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.buttonsTable.Size = new System.Drawing.Size(444, 45);
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
            this.cancelButton.Location = new System.Drawing.Point(224, 4);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(218, 41);
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
            this.createWalletButton.Size = new System.Drawing.Size(218, 41);
            this.createWalletButton.TabIndex = 1;
            this.createWalletButton.Text = "Create Wallet";
            this.createWalletButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createWalletButton.Click += new System.EventHandler(this.CreateWalletButton_Click);
            // 
            // walletNameTable
            // 
            this.walletNameTable.ColumnCount = 2;
            this.walletNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.walletNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.walletNameTable.Controls.Add(this.panel1, 0, 0);
            this.walletNameTable.Controls.Add(this.panel2, 1, 0);
            this.walletNameTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walletNameTable.Location = new System.Drawing.Point(2, 2);
            this.walletNameTable.Margin = new System.Windows.Forms.Padding(2);
            this.walletNameTable.Name = "walletNameTable";
            this.walletNameTable.RowCount = 1;
            this.walletNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.walletNameTable.Size = new System.Drawing.Size(444, 31);
            this.walletNameTable.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.walletNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 25);
            this.panel1.TabIndex = 5;
            // 
            // walletNameLabel
            // 
            this.walletNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.walletNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.walletNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.walletNameLabel.Location = new System.Drawing.Point(0, 0);
            this.walletNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.walletNameLabel.Name = "walletNameLabel";
            this.walletNameLabel.Size = new System.Drawing.Size(171, 31);
            this.walletNameLabel.TabIndex = 4;
            this.walletNameLabel.Text = "Wallet Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.walletNameText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 25);
            this.panel2.TabIndex = 6;
            // 
            // walletNameText
            // 
            this.walletNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.walletNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.walletNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.walletNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletNameText.ForeColor = System.Drawing.Color.White;
            this.walletNameText.Location = new System.Drawing.Point(0, 0);
            this.walletNameText.Margin = new System.Windows.Forms.Padding(2);
            this.walletNameText.MaxLength = 24;
            this.walletNameText.Name = "walletNameText";
            this.walletNameText.Size = new System.Drawing.Size(261, 29);
            this.walletNameText.TabIndex = 5;
            // 
            // createLogo
            // 
            this.createLogo.BackgroundImage = global::PlenteumWallet.Properties.Resources.ple_banner;
            this.createLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.createLogo.Location = new System.Drawing.Point(0, 0);
            this.createLogo.Margin = new System.Windows.Forms.Padding(2);
            this.createLogo.Name = "createLogo";
            this.createLogo.Size = new System.Drawing.Size(448, 162);
            this.createLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.createLogo.TabIndex = 0;
            this.createLogo.TabStop = false;
            // 
            // CreateWalletPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 400);
            this.Controls.Add(this.createMainPanel);
            this.Controls.Add(this.createLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateWalletPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plenteum Wallet";
            this.createMainPanel.ResumeLayout(false);
            this.createMainTable.ResumeLayout(false);
            this.passwordConfirmTable.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.passwordTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.buttonsTable.ResumeLayout(false);
            this.buttonsTable.PerformLayout();
            this.walletNameTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createLogo)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox createLogo;
    private System.Windows.Forms.Panel createMainPanel;
    private System.Windows.Forms.Label welcomeLabel;
    private System.Windows.Forms.TableLayoutPanel createMainTable;
    private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.ProgressBar createProgressbar;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.TableLayoutPanel passwordConfirmTable;
        private System.Windows.Forms.TableLayoutPanel passwordTable;
        private System.Windows.Forms.TableLayoutPanel walletNameTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label walletNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox walletNameText;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label passwordConfirmLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox passwordConfirmText;
        private PlenteumWalletLabelButton cancelButton;
        private PlenteumWalletLabelButton createWalletButton;
    }
}
