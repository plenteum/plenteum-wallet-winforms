namespace PlenteumWallet
{
    partial class UpdatePrompt
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
            this.updateMainPanel = new System.Windows.Forms.Panel();
            this.updateBar = new System.Windows.Forms.ProgressBar();
            this.updaterLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.updateLogo = new System.Windows.Forms.PictureBox();
            this.updateWorker = new System.ComponentModel.BackgroundWorker();
            this.updateMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // updateMainPanel
            // 
            this.updateMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.updateMainPanel.Controls.Add(this.updateBar);
            this.updateMainPanel.Controls.Add(this.updaterLabel);
            this.updateMainPanel.Controls.Add(this.welcomeLabel);
            this.updateMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateMainPanel.Location = new System.Drawing.Point(0, 162);
            this.updateMainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateMainPanel.Name = "updateMainPanel";
            this.updateMainPanel.Size = new System.Drawing.Size(448, 99);
            this.updateMainPanel.TabIndex = 1;
            // 
            // updateBar
            // 
            this.updateBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updateBar.ForeColor = System.Drawing.Color.Green;
            this.updateBar.Location = new System.Drawing.Point(0, 80);
            this.updateBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBar.Name = "updateBar";
            this.updateBar.Size = new System.Drawing.Size(448, 19);
            this.updateBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.updateBar.TabIndex = 99;
            // 
            // updaterLabel
            // 
            this.updaterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.updaterLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.updaterLabel.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updaterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(163)))), ((int)(((byte)(197)))));
            this.updaterLabel.Location = new System.Drawing.Point(0, 46);
            this.updaterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updaterLabel.Name = "updaterLabel";
            this.updaterLabel.Size = new System.Drawing.Size(448, 32);
            this.updaterLabel.TabIndex = 98;
            this.updaterLabel.Text = "Checking for updates ...";
            this.updaterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.welcomeLabel.Size = new System.Drawing.Size(448, 46);
            this.welcomeLabel.TabIndex = 97;
            this.welcomeLabel.Text = "Welcome to Plenteum Wallet";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateLogo
            // 
            this.updateLogo.BackgroundImage = global::PlenteumWallet.Properties.Resources.ple_banner;
            this.updateLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateLogo.Location = new System.Drawing.Point(0, 0);
            this.updateLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateLogo.Name = "updateLogo";
            this.updateLogo.Size = new System.Drawing.Size(448, 162);
            this.updateLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updateLogo.TabIndex = 0;
            this.updateLogo.TabStop = false;
            // 
            // updateWorker
            // 
            this.updateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpdateWorker_DoWork);
            this.updateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UpdateWorker_RunWorkerCompleted);
            // 
            // UpdatePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.updateMainPanel);
            this.Controls.Add(this.updateLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdatePrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdatePrompt_Load);
            this.updateMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox updateLogo;
        private System.Windows.Forms.Panel updateMainPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label updaterLabel;
        private System.Windows.Forms.ProgressBar updateBar;
        private System.ComponentModel.BackgroundWorker updateWorker;
    }
}
