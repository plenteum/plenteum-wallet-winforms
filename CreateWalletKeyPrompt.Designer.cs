namespace PlenteumWallet
{
    partial class CreateWalletKeyPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateWalletKeyPrompt));
            this.createMainPanel = new System.Windows.Forms.Panel();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.createWalletButton = new System.Windows.Forms.Label();
            this.KeysTextbox = new System.Windows.Forms.TextBox();
            this.createLogo = new System.Windows.Forms.PictureBox();
            this.createMainPanel.SuspendLayout();
            this.createMainTable.SuspendLayout();
            this.buttonsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // createMainPanel
            // 
            this.createMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.createMainPanel.Controls.Add(this.CreateLabel);
            this.createMainPanel.Controls.Add(this.welcomeLabel);
            this.createMainPanel.Controls.Add(this.createMainTable);
            this.createMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createMainPanel.Location = new System.Drawing.Point(0, 149);
            this.createMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.createMainPanel.Name = "createMainPanel";
            this.createMainPanel.Size = new System.Drawing.Size(448, 251);
            this.createMainPanel.TabIndex = 1;
            // 
            // CreateLabel
            // 
            this.CreateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CreateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLabel.ForeColor = System.Drawing.Color.White;
            this.CreateLabel.Location = new System.Drawing.Point(0, 46);
            this.CreateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(448, 49);
            this.CreateLabel.TabIndex = 2;
            this.CreateLabel.Text = "Save the keys in the following output! You  will not be able to \r\nrestore your wa" +
    "llet in case of failure without them!";
            this.CreateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Red;
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(448, 46);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "IMPORTANT!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createMainTable
            // 
            this.createMainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.createMainTable.ColumnCount = 1;
            this.createMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.createMainTable.Controls.Add(this.buttonsTable, 0, 1);
            this.createMainTable.Controls.Add(this.KeysTextbox, 0, 0);
            this.createMainTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createMainTable.Location = new System.Drawing.Point(0, 97);
            this.createMainTable.Margin = new System.Windows.Forms.Padding(2);
            this.createMainTable.Name = "createMainTable";
            this.createMainTable.RowCount = 2;
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.77922F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.22078F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.createMainTable.Size = new System.Drawing.Size(448, 154);
            this.createMainTable.TabIndex = 0;
            // 
            // buttonsTable
            // 
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.createWalletButton, 0, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTable.Location = new System.Drawing.Point(2, 110);
            this.buttonsTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.buttonsTable.Size = new System.Drawing.Size(444, 42);
            this.buttonsTable.TabIndex = 3;
            // 
            // createWalletButton
            // 
            this.createWalletButton.AutoSize = true;
            this.createWalletButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.buttonsTable.SetColumnSpan(this.createWalletButton, 2);
            this.createWalletButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createWalletButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createWalletButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createWalletButton.ForeColor = System.Drawing.Color.White;
            this.createWalletButton.Location = new System.Drawing.Point(2, 4);
            this.createWalletButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.createWalletButton.Name = "createWalletButton";
            this.createWalletButton.Size = new System.Drawing.Size(440, 38);
            this.createWalletButton.TabIndex = 1;
            this.createWalletButton.Text = "I have saved my keys! (Continue)";
            this.createWalletButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createWalletButton.Click += new System.EventHandler(this.CreateWalletButton_Click);
            // 
            // KeysTextbox
            // 
            this.KeysTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.KeysTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeysTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeysTextbox.Location = new System.Drawing.Point(3, 3);
            this.KeysTextbox.Multiline = true;
            this.KeysTextbox.Name = "KeysTextbox";
            this.KeysTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeysTextbox.Size = new System.Drawing.Size(442, 102);
            this.KeysTextbox.TabIndex = 4;
            // 
            // createLogo
            // 
            this.createLogo.BackgroundImage = global::PlenteumWallet.Properties.Resources.ple_banner;
            this.createLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.createLogo.Location = new System.Drawing.Point(0, 0);
            this.createLogo.Margin = new System.Windows.Forms.Padding(2);
            this.createLogo.Name = "createLogo";
            this.createLogo.Size = new System.Drawing.Size(448, 149);
            this.createLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.createLogo.TabIndex = 0;
            this.createLogo.TabStop = false;
            // 
            // CreateWalletKeyPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 400);
            this.Controls.Add(this.createMainPanel);
            this.Controls.Add(this.createLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateWalletKeyPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plenteum Wallet";
            this.createMainPanel.ResumeLayout(false);
            this.createMainTable.ResumeLayout(false);
            this.createMainTable.PerformLayout();
            this.buttonsTable.ResumeLayout(false);
            this.buttonsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox createLogo;
        private System.Windows.Forms.Panel createMainPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TableLayoutPanel createMainTable;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Label createWalletButton;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.TextBox KeysTextbox;
    }
}
