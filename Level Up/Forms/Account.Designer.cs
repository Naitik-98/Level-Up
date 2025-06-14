namespace Level_Up.Forms
{
    partial class Account
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblOwnedGame = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnStore);
            this.panelLeft.Controls.Add(this.btnLibrary);
            this.panelLeft.Controls.Add(this.btnAccount);
            this.panelLeft.Location = new System.Drawing.Point(-6, -10);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 700);
            this.panelLeft.TabIndex = 4;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
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
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSettings.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(53, 580);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(194, 56);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = false;
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
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Indigo;
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.MenuText;
            this.panelMain.Controls.Add(this.lblDOB);
            this.panelMain.Controls.Add(this.lblOwnedGame);
            this.panelMain.Controls.Add(this.lblUsername);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Location = new System.Drawing.Point(300, 92);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(970, 585);
            this.panelMain.TabIndex = 7;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDOB.Location = new System.Drawing.Point(72, 409);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(235, 37);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth: ";
            this.lblDOB.Click += new System.EventHandler(this.lblDOB_Click);
            // 
            // lblOwnedGame
            // 
            this.lblOwnedGame.AutoSize = true;
            this.lblOwnedGame.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnedGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedGame.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblOwnedGame.Location = new System.Drawing.Point(72, 306);
            this.lblOwnedGame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwnedGame.Name = "lblOwnedGame";
            this.lblOwnedGame.Size = new System.Drawing.Size(331, 37);
            this.lblOwnedGame.TabIndex = 3;
            this.lblOwnedGame.Text = "Total Owned Game: ";
          
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblUsername.Location = new System.Drawing.Point(72, 198);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(192, 37);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblName.Location = new System.Drawing.Point(72, 90);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:  ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.labelTop.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTop.Location = new System.Drawing.Point(296, 5);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(985, 81);
            this.labelTop.TabIndex = 6;
            this.labelTop.Text = "Account";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.Click += new System.EventHandler(this.labelTop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-6, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // backbtn
            // 
            this.backbtn.Image = global::Level_Up.Properties.Resources.Screenshot_2025_06_11_221343;
            this.backbtn.Location = new System.Drawing.Point(300, 16);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(70, 70);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbtn.TabIndex = 0;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1283, 681);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.label1);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backbtn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblOwnedGame;
    }
}