namespace Level_Up.Forms
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccount.Location = new System.Drawing.Point(53, 311);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(194, 56);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "ACCOUNT";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLibrary.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLibrary.Location = new System.Drawing.Point(53, 403);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(194, 56);
            this.btnLibrary.TabIndex = 3;
            this.btnLibrary.Text = "LIBRARY";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStore.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStore.Location = new System.Drawing.Point(53, 493);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(194, 56);
            this.btnStore.TabIndex = 4;
            this.btnStore.Text = "STORE";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Indigo;
            this.btnSettings.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(53, 580);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(194, 56);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnStore);
            this.panelLeft.Controls.Add(this.btnLibrary);
            this.panelLeft.Controls.Add(this.btnAccount);
            this.panelLeft.Location = new System.Drawing.Point(1, 9);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 700);
            this.panelLeft.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Level_Up.Properties.Resources.Picsart_25_05_21_17_53_38_533;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.labelTop.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTop.Location = new System.Drawing.Point(307, 9);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(1090, 81);
            this.labelTop.TabIndex = 6;
            this.labelTop.Text = "Settings";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backbtn
            // 
            this.backbtn.Image = global::Level_Up.Properties.Resources.Screenshot_2025_06_11_221343;
            this.backbtn.Location = new System.Drawing.Point(307, 20);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(70, 70);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbtn.TabIndex = 1;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Image = global::Level_Up.Properties.Resources._1280x720_temp_68487894b594e;
            this.Logoutbtn.Location = new System.Drawing.Point(466, 411);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(150, 150);
            this.Logoutbtn.TabIndex = 0;
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblName.Location = new System.Drawing.Point(120, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "New Name : ";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblChange.Location = new System.Drawing.Point(308, 9);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(403, 42);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "Change Account Details";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.MenuText;
            this.panelMain.Controls.Add(this.txtCurrentPassword);
            this.panelMain.Controls.Add(this.txtNewPassword);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.txtName);
            this.panelMain.Controls.Add(this.btnUpdate);
            this.panelMain.Controls.Add(this.lblCurrentPassword);
            this.panelMain.Controls.Add(this.lblPassword);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Controls.Add(this.lblChange);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Controls.Add(this.Logoutbtn);
            this.panelMain.Location = new System.Drawing.Point(307, 93);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1066, 585);
            this.panelMain.TabIndex = 7;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.Silver;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(273, 261);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(500, 34);
            this.txtCurrentPassword.TabIndex = 10;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Silver;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(273, 203);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(500, 34);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(273, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 34);
            this.txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(273, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 34);
            this.txtName.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Location = new System.Drawing.Point(466, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblCurrentPassword.Location = new System.Drawing.Point(49, 267);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(218, 28);
            this.lblCurrentPassword.TabIndex = 5;
            this.lblCurrentPassword.Text = "Current Password : ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblPassword.Location = new System.Drawing.Point(82, 209);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(185, 28);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "New Password : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblEmail.Location = new System.Drawing.Point(126, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 28);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "New Email : ";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1384, 681);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
    }
}