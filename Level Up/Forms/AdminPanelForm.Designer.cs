namespace Level_Up.Forms
{
    partial class AdminPanelForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblGameImage = new System.Windows.Forms.Label();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.txtGameDescription = new System.Windows.Forms.TextBox();
            this.txtGamePrice = new System.Windows.Forms.TextBox();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.lstGames = new System.Windows.Forms.ListBox();
            this.btnRemoveGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(441, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Panel";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblGameName.Location = new System.Drawing.Point(33, 134);
            this.lblGameName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(160, 28);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "Game Name : ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDescription.Location = new System.Drawing.Point(33, 245);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(152, 28);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPrice.Location = new System.Drawing.Point(33, 359);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 28);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price : ";
            // 
            // lblGameImage
            // 
            this.lblGameImage.AutoSize = true;
            this.lblGameImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameImage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblGameImage.Location = new System.Drawing.Point(33, 442);
            this.lblGameImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameImage.Name = "lblGameImage";
            this.lblGameImage.Size = new System.Drawing.Size(163, 28);
            this.lblGameImage.TabIndex = 4;
            this.lblGameImage.Text = "Game Image : ";
            // 
            // txtGameName
            // 
            this.txtGameName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtGameName.Location = new System.Drawing.Point(221, 133);
            this.txtGameName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(495, 31);
            this.txtGameName.TabIndex = 5;
            // 
            // txtGameDescription
            // 
            this.txtGameDescription.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtGameDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameDescription.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtGameDescription.Location = new System.Drawing.Point(221, 190);
            this.txtGameDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGameDescription.Multiline = true;
            this.txtGameDescription.Name = "txtGameDescription";
            this.txtGameDescription.Size = new System.Drawing.Size(495, 140);
            this.txtGameDescription.TabIndex = 6;
            // 
            // txtGamePrice
            // 
            this.txtGamePrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtGamePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamePrice.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtGamePrice.Location = new System.Drawing.Point(221, 358);
            this.txtGamePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGamePrice.Name = "txtGamePrice";
            this.txtGamePrice.Size = new System.Drawing.Size(495, 31);
            this.txtGamePrice.TabIndex = 7;
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Location = new System.Drawing.Point(480, 410);
            this.pictureBoxGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(225, 131);
            this.pictureBoxGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGame.TabIndex = 8;
            this.pictureBoxGame.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBrowseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.Location = new System.Drawing.Point(221, 426);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(150, 62);
            this.btnBrowseImage.TabIndex = 9;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.Teal;
            this.btnAddGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGame.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddGame.Location = new System.Drawing.Point(542, 583);
            this.btnAddGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(201, 66);
            this.btnAddGame.TabIndex = 10;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::Level_Up.Properties.Resources.Screenshot_2025_06_11_221343;
            this.btnLogout.Location = new System.Drawing.Point(10, 559);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 108);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogout.TabIndex = 11;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstGames
            // 
            this.lstGames.BackColor = System.Drawing.Color.LightCyan;
            this.lstGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGames.ForeColor = System.Drawing.Color.Black;
            this.lstGames.FormattingEnabled = true;
            this.lstGames.ItemHeight = 20;
            this.lstGames.Location = new System.Drawing.Point(882, 93);
            this.lstGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(305, 364);
            this.lstGames.TabIndex = 12;
            // 
            // btnRemoveGame
            // 
            this.btnRemoveGame.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGame.Location = new System.Drawing.Point(882, 479);
            this.btnRemoveGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveGame.Name = "btnRemoveGame";
            this.btnRemoveGame.Size = new System.Drawing.Size(150, 62);
            this.btnRemoveGame.TabIndex = 13;
            this.btnRemoveGame.Text = "Remove";
            this.btnRemoveGame.UseVisualStyleBackColor = false;
            this.btnRemoveGame.Click += new System.EventHandler(this.btnRemoveGame_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnRemoveGame);
            this.Controls.Add(this.lstGames);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.pictureBoxGame);
            this.Controls.Add(this.txtGamePrice);
            this.Controls.Add(this.txtGameDescription);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.lblGameImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblGameImage;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.TextBox txtGameDescription;
        private System.Windows.Forms.TextBox txtGamePrice;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Button btnRemoveGame;
    }
}