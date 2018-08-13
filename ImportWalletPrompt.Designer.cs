namespace PlenteumWallet
{
    partial class ImportWalletPrompt
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
            this.importMainPanel = new System.Windows.Forms.Panel();
            this.importLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.importProgressbar = new System.Windows.Forms.ProgressBar();
            this.importMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.spendSecretKeyTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.spendSecretKeyLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.spendSecretKeyText = new System.Windows.Forms.TextBox();
            this.viewSecretKeyTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.viewSecretKeyLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.viewSecretKeyText = new System.Windows.Forms.TextBox();
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
            this.importWalletButton = new PlenteumWallet.PlenteumWalletLabelButton();
            this.walletNameTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.walletNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.walletNameText = new System.Windows.Forms.TextBox();
            this.importLogo = new System.Windows.Forms.PictureBox();
            this.importMainPanel.SuspendLayout();
            this.importMainTable.SuspendLayout();
            this.spendSecretKeyTable.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.viewSecretKeyTable.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.importLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // importMainPanel
            // 
            this.importMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.importMainPanel.Controls.Add(this.importLabel);
            this.importMainPanel.Controls.Add(this.welcomeLabel);
            this.importMainPanel.Controls.Add(this.importProgressbar);
            this.importMainPanel.Controls.Add(this.importMainTable);
            this.importMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importMainPanel.Location = new System.Drawing.Point(0, 162);
            this.importMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.importMainPanel.Name = "importMainPanel";
            this.importMainPanel.Size = new System.Drawing.Size(448, 364);
            this.importMainPanel.TabIndex = 1;
            // 
            // importLabel
            // 
            this.importLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.importLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.importLabel.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.importLabel.Location = new System.Drawing.Point(0, 50);
            this.importLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.importLabel.Name = "importLabel";
            this.importLabel.Size = new System.Drawing.Size(448, 32);
            this.importLabel.TabIndex = 2;
            this.importLabel.Text = "Wallet Import:";
            this.importLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // importProgressbar
            // 
            this.importProgressbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.importProgressbar.ForeColor = System.Drawing.Color.Green;
            this.importProgressbar.Location = new System.Drawing.Point(0, 0);
            this.importProgressbar.Margin = new System.Windows.Forms.Padding(2);
            this.importProgressbar.Name = "importProgressbar";
            this.importProgressbar.Size = new System.Drawing.Size(448, 4);
            this.importProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.importProgressbar.TabIndex = 3;
            this.importProgressbar.Visible = false;
            // 
            // importMainTable
            // 
            this.importMainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.importMainTable.ColumnCount = 1;
            this.importMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.importMainTable.Controls.Add(this.spendSecretKeyTable, 0, 4);
            this.importMainTable.Controls.Add(this.viewSecretKeyTable, 0, 3);
            this.importMainTable.Controls.Add(this.passwordConfirmTable, 0, 2);
            this.importMainTable.Controls.Add(this.passwordTable, 0, 1);
            this.importMainTable.Controls.Add(this.buttonsTable, 0, 4);
            this.importMainTable.Controls.Add(this.walletNameTable, 0, 0);
            this.importMainTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.importMainTable.Location = new System.Drawing.Point(0, 96);
            this.importMainTable.Margin = new System.Windows.Forms.Padding(2);
            this.importMainTable.Name = "importMainTable";
            this.importMainTable.RowCount = 6;
            this.importMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90546F));
            this.importMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90546F));
            this.importMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90546F));
            this.importMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90306F));
            this.importMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90283F));
            this.importMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.47774F));
            this.importMainTable.Size = new System.Drawing.Size(448, 268);
            this.importMainTable.TabIndex = 0;
            // 
            // spendSecretKeyTable
            // 
            this.spendSecretKeyTable.ColumnCount = 2;
            this.spendSecretKeyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.spendSecretKeyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.spendSecretKeyTable.Controls.Add(this.panel9, 0, 0);
            this.spendSecretKeyTable.Controls.Add(this.panel10, 1, 0);
            this.spendSecretKeyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendSecretKeyTable.Location = new System.Drawing.Point(2, 170);
            this.spendSecretKeyTable.Margin = new System.Windows.Forms.Padding(2);
            this.spendSecretKeyTable.Name = "spendSecretKeyTable";
            this.spendSecretKeyTable.RowCount = 1;
            this.spendSecretKeyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.spendSecretKeyTable.Size = new System.Drawing.Size(444, 38);
            this.spendSecretKeyTable.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.spendSecretKeyLabel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(171, 32);
            this.panel9.TabIndex = 0;
            // 
            // spendSecretKeyLabel
            // 
            this.spendSecretKeyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.spendSecretKeyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.spendSecretKeyLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spendSecretKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.spendSecretKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.spendSecretKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.spendSecretKeyLabel.Name = "spendSecretKeyLabel";
            this.spendSecretKeyLabel.Size = new System.Drawing.Size(171, 31);
            this.spendSecretKeyLabel.TabIndex = 5;
            this.spendSecretKeyLabel.Text = "Private Spend Key:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.spendSecretKeyText);
            this.panel10.Location = new System.Drawing.Point(180, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(261, 32);
            this.panel10.TabIndex = 1;
            // 
            // spendSecretKeyText
            // 
            this.spendSecretKeyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.spendSecretKeyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spendSecretKeyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendSecretKeyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spendSecretKeyText.ForeColor = System.Drawing.Color.White;
            this.spendSecretKeyText.Location = new System.Drawing.Point(0, 0);
            this.spendSecretKeyText.Margin = new System.Windows.Forms.Padding(2);
            this.spendSecretKeyText.MaxLength = 150;
            this.spendSecretKeyText.Name = "spendSecretKeyText";
            this.spendSecretKeyText.Size = new System.Drawing.Size(261, 29);
            this.spendSecretKeyText.TabIndex = 7;
            this.spendSecretKeyText.UseSystemPasswordChar = true;
            // 
            // viewSecretKeyTable
            // 
            this.viewSecretKeyTable.ColumnCount = 2;
            this.viewSecretKeyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.viewSecretKeyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.viewSecretKeyTable.Controls.Add(this.panel7, 0, 0);
            this.viewSecretKeyTable.Controls.Add(this.panel8, 1, 0);
            this.viewSecretKeyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSecretKeyTable.Location = new System.Drawing.Point(2, 128);
            this.viewSecretKeyTable.Margin = new System.Windows.Forms.Padding(2);
            this.viewSecretKeyTable.Name = "viewSecretKeyTable";
            this.viewSecretKeyTable.RowCount = 1;
            this.viewSecretKeyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.viewSecretKeyTable.Size = new System.Drawing.Size(444, 38);
            this.viewSecretKeyTable.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.viewSecretKeyLabel);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 25);
            this.panel7.TabIndex = 0;
            // 
            // viewSecretKeyLabel
            // 
            this.viewSecretKeyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.viewSecretKeyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewSecretKeyLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSecretKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.viewSecretKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.viewSecretKeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.viewSecretKeyLabel.Name = "viewSecretKeyLabel";
            this.viewSecretKeyLabel.Size = new System.Drawing.Size(171, 31);
            this.viewSecretKeyLabel.TabIndex = 5;
            this.viewSecretKeyLabel.Text = "Private View Key:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.viewSecretKeyText);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(180, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(261, 32);
            this.panel8.TabIndex = 1;
            // 
            // viewSecretKeyText
            // 
            this.viewSecretKeyText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.viewSecretKeyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewSecretKeyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSecretKeyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSecretKeyText.ForeColor = System.Drawing.Color.White;
            this.viewSecretKeyText.Location = new System.Drawing.Point(0, 0);
            this.viewSecretKeyText.Margin = new System.Windows.Forms.Padding(2);
            this.viewSecretKeyText.MaxLength = 150;
            this.viewSecretKeyText.Name = "viewSecretKeyText";
            this.viewSecretKeyText.Size = new System.Drawing.Size(261, 29);
            this.viewSecretKeyText.TabIndex = 6;
            this.viewSecretKeyText.UseSystemPasswordChar = true;
            // 
            // passwordConfirmTable
            // 
            this.passwordConfirmTable.ColumnCount = 2;
            this.passwordConfirmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.passwordConfirmTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.passwordConfirmTable.Controls.Add(this.panel5, 0, 0);
            this.passwordConfirmTable.Controls.Add(this.panel6, 1, 0);
            this.passwordConfirmTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordConfirmTable.Location = new System.Drawing.Point(2, 86);
            this.passwordConfirmTable.Margin = new System.Windows.Forms.Padding(2);
            this.passwordConfirmTable.Name = "passwordConfirmTable";
            this.passwordConfirmTable.RowCount = 1;
            this.passwordConfirmTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passwordConfirmTable.Size = new System.Drawing.Size(444, 38);
            this.passwordConfirmTable.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.passwordConfirmLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 32);
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
            this.panel6.Size = new System.Drawing.Size(261, 32);
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
            this.passwordConfirmText.MaxLength = 151;
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
            this.passwordTable.Location = new System.Drawing.Point(2, 44);
            this.passwordTable.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTable.Name = "passwordTable";
            this.passwordTable.RowCount = 1;
            this.passwordTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.passwordTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.passwordTable.Size = new System.Drawing.Size(444, 38);
            this.passwordTable.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.passwordLabel);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 21);
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
            this.panel4.Size = new System.Drawing.Size(261, 32);
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
            this.passwordText.MaxLength = 150;
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
            this.buttonsTable.Controls.Add(this.importWalletButton, 0, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTable.Location = new System.Drawing.Point(2, 212);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.buttonsTable.Size = new System.Drawing.Size(444, 54);
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
            this.cancelButton.Size = new System.Drawing.Size(218, 50);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // importWalletButton
            // 
            this.importWalletButton.AutoSize = true;
            this.importWalletButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.importWalletButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importWalletButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importWalletButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importWalletButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importWalletButton.Location = new System.Drawing.Point(2, 4);
            this.importWalletButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.importWalletButton.Name = "importWalletButton";
            this.importWalletButton.Size = new System.Drawing.Size(218, 50);
            this.importWalletButton.TabIndex = 1;
            this.importWalletButton.Text = "Import Wallet";
            this.importWalletButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importWalletButton.Click += new System.EventHandler(this.ImportWalletButton_Click);
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
            this.walletNameTable.Size = new System.Drawing.Size(444, 38);
            this.walletNameTable.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.walletNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 32);
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
            this.panel2.Size = new System.Drawing.Size(261, 32);
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
            // importLogo
            // 
            this.importLogo.BackgroundImage = global::PlenteumWallet.Properties.Resources.ple_banner;
            this.importLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.importLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.importLogo.Location = new System.Drawing.Point(0, 0);
            this.importLogo.Margin = new System.Windows.Forms.Padding(2);
            this.importLogo.Name = "importLogo";
            this.importLogo.Size = new System.Drawing.Size(448, 162);
            this.importLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.importLogo.TabIndex = 0;
            this.importLogo.TabStop = false;
            // 
            // ImportWalletPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 526);
            this.Controls.Add(this.importMainPanel);
            this.Controls.Add(this.importLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImportWalletPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.importMainPanel.ResumeLayout(false);
            this.importMainTable.ResumeLayout(false);
            this.spendSecretKeyTable.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.viewSecretKeyTable.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.importLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox importLogo;
        private System.Windows.Forms.Panel importMainPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TableLayoutPanel importMainTable;
        private System.Windows.Forms.Label importLabel;
        private PlenteumWalletLabelButton cancelButton;
        private PlenteumWalletLabelButton importWalletButton;
        private System.Windows.Forms.ProgressBar importProgressbar;
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
        private System.Windows.Forms.TableLayoutPanel spendSecretKeyTable;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label spendSecretKeyLabel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox spendSecretKeyText;
        private System.Windows.Forms.TableLayoutPanel viewSecretKeyTable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label viewSecretKeyLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox viewSecretKeyText;
    }
}
