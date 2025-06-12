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
            this.labelTop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblOwnedGame = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
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
            this.panelLeft.Location = new System.Drawing.Point(-9, -15);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(450, 1077);
            this.panelLeft.TabIndex = 4;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Level_Up.Properties.Resources.Picsart_25_05_21_17_53_38_533;
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSettings.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(80, 892);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(291, 86);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnStore.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStore.Location = new System.Drawing.Point(80, 758);
            this.btnStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(291, 86);
            this.btnStore.TabIndex = 4;
            this.btnStore.Text = "STORE";
            this.btnStore.UseVisualStyleBackColor = false;
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLibrary.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLibrary.Location = new System.Drawing.Point(80, 620);
            this.btnLibrary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(291, 86);
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
            this.btnAccount.Location = new System.Drawing.Point(80, 478);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(291, 86);
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
            this.panelMain.Location = new System.Drawing.Point(450, 143);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(2453, 5171);
            this.panelMain.TabIndex = 7;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.labelTop.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTop.Location = new System.Drawing.Point(444, 8);
            this.labelTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(1635, 125);
            this.labelTop.TabIndex = 6;
            this.labelTop.Text = "Account";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.Click += new System.EventHandler(this.labelTop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-9, -15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // backbtn
            // 
            this.backbtn.Image = global::Level_Up.Properties.Resources.Screenshot_2025_06_11_221343;
            this.backbtn.Location = new System.Drawing.Point(450, 25);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(105, 108);
            this.backbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backbtn.TabIndex = 0;
            this.backbtn.TabStop = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(86, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:  ";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(86, 254);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(192, 37);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username: ";
            // 
            // lblOwnedGame
            // 
            this.lblOwnedGame.AutoSize = true;
            this.lblOwnedGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnedGame.Location = new System.Drawing.Point(86, 366);
            this.lblOwnedGame.Name = "lblOwnedGame";
            this.lblOwnedGame.Size = new System.Drawing.Size(331, 37);
            this.lblOwnedGame.TabIndex = 3;
            this.lblOwnedGame.Text = "Total Owned Game: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDOB.Location = new System.Drawing.Point(86, 471);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(235, 37);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth: ";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1048);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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