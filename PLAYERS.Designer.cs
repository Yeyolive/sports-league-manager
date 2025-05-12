
namespace Daykel_Marzo_FINALS_ProjectAssignment_STM
{
    partial class PLAYERS
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
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PPGlistBox = new System.Windows.Forms.ListBox();
            this.PointsPerGame = new System.Windows.Forms.OpenFileDialog();
            this.PPGbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RPGlistBox = new System.Windows.Forms.ListBox();
            this.RPGbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.APGlistBox = new System.Windows.Forms.ListBox();
            this.APGbutton = new System.Windows.Forms.Button();
            this.ReboundsPerGame = new System.Windows.Forms.OpenFileDialog();
            this.AssistsPerGame = new System.Windows.Forms.OpenFileDialog();
            this.StealsPerGame = new System.Windows.Forms.OpenFileDialog();
            this.BlocksPerGame = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SPGlistBox = new System.Windows.Forms.ListBox();
            this.BPGlistBox = new System.Windows.Forms.ListBox();
            this.SPGbutton = new System.Windows.Forms.Button();
            this.BPGbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(860, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 41);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "NBA STATS LEADERS - Top 5 (2021)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leading NBA Points Per Game:";
            // 
            // PPGlistBox
            // 
            this.PPGlistBox.FormattingEnabled = true;
            this.PPGlistBox.ItemHeight = 16;
            this.PPGlistBox.Location = new System.Drawing.Point(13, 120);
            this.PPGlistBox.Name = "PPGlistBox";
            this.PPGlistBox.Size = new System.Drawing.Size(266, 228);
            this.PPGlistBox.TabIndex = 5;
            // 
            // PointsPerGame
            // 
            this.PointsPerGame.FileName = "PointsPerGame";
            // 
            // PPGbutton
            // 
            this.PPGbutton.Location = new System.Drawing.Point(89, 354);
            this.PPGbutton.Name = "PPGbutton";
            this.PPGbutton.Size = new System.Drawing.Size(111, 49);
            this.PPGbutton.TabIndex = 6;
            this.PPGbutton.Text = " Points Per Game";
            this.PPGbutton.UseVisualStyleBackColor = true;
            this.PPGbutton.Click += new System.EventHandler(this.PPGbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Leading NBA Rebounds Per Game:";
            // 
            // RPGlistBox
            // 
            this.RPGlistBox.FormattingEnabled = true;
            this.RPGlistBox.ItemHeight = 16;
            this.RPGlistBox.Location = new System.Drawing.Point(339, 120);
            this.RPGlistBox.Name = "RPGlistBox";
            this.RPGlistBox.Size = new System.Drawing.Size(266, 228);
            this.RPGlistBox.TabIndex = 8;
            // 
            // RPGbutton
            // 
            this.RPGbutton.Location = new System.Drawing.Point(418, 354);
            this.RPGbutton.Name = "RPGbutton";
            this.RPGbutton.Size = new System.Drawing.Size(111, 49);
            this.RPGbutton.TabIndex = 9;
            this.RPGbutton.Text = "Rebounds Per Game";
            this.RPGbutton.UseVisualStyleBackColor = true;
            this.RPGbutton.Click += new System.EventHandler(this.RPGbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Leading NBA Assists Per Game:";
            // 
            // APGlistBox
            // 
            this.APGlistBox.FormattingEnabled = true;
            this.APGlistBox.ItemHeight = 16;
            this.APGlistBox.Location = new System.Drawing.Point(657, 120);
            this.APGlistBox.Name = "APGlistBox";
            this.APGlistBox.Size = new System.Drawing.Size(266, 228);
            this.APGlistBox.TabIndex = 11;
            // 
            // APGbutton
            // 
            this.APGbutton.Location = new System.Drawing.Point(733, 354);
            this.APGbutton.Name = "APGbutton";
            this.APGbutton.Size = new System.Drawing.Size(111, 49);
            this.APGbutton.TabIndex = 12;
            this.APGbutton.Text = "Assists Per Game";
            this.APGbutton.UseVisualStyleBackColor = true;
            this.APGbutton.Click += new System.EventHandler(this.APGbutton_Click);
            // 
            // ReboundsPerGame
            // 
            this.ReboundsPerGame.FileName = "ReboundsPerGame";
            // 
            // AssistsPerGame
            // 
            this.AssistsPerGame.FileName = "AssistsPerGame";
            // 
            // StealsPerGame
            // 
            this.StealsPerGame.FileName = "StealsPerGame";
            // 
            // BlocksPerGame
            // 
            this.BlocksPerGame.FileName = "BlocksPerGame";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Leading NBA Steals Per Game:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Leading NBA Blocks Per Game:";
            // 
            // SPGlistBox
            // 
            this.SPGlistBox.FormattingEnabled = true;
            this.SPGlistBox.ItemHeight = 16;
            this.SPGlistBox.Location = new System.Drawing.Point(13, 498);
            this.SPGlistBox.Name = "SPGlistBox";
            this.SPGlistBox.Size = new System.Drawing.Size(266, 228);
            this.SPGlistBox.TabIndex = 15;
            // 
            // BPGlistBox
            // 
            this.BPGlistBox.FormattingEnabled = true;
            this.BPGlistBox.ItemHeight = 16;
            this.BPGlistBox.Location = new System.Drawing.Point(339, 498);
            this.BPGlistBox.Name = "BPGlistBox";
            this.BPGlistBox.Size = new System.Drawing.Size(266, 228);
            this.BPGlistBox.TabIndex = 16;
            // 
            // SPGbutton
            // 
            this.SPGbutton.Location = new System.Drawing.Point(89, 742);
            this.SPGbutton.Name = "SPGbutton";
            this.SPGbutton.Size = new System.Drawing.Size(111, 49);
            this.SPGbutton.TabIndex = 17;
            this.SPGbutton.Text = "Steals Per Game";
            this.SPGbutton.UseVisualStyleBackColor = true;
            this.SPGbutton.Click += new System.EventHandler(this.SPGbutton_Click);
            // 
            // BPGbutton
            // 
            this.BPGbutton.Location = new System.Drawing.Point(418, 742);
            this.BPGbutton.Name = "BPGbutton";
            this.BPGbutton.Size = new System.Drawing.Size(111, 49);
            this.BPGbutton.TabIndex = 18;
            this.BPGbutton.Text = "Blocks Per Game";
            this.BPGbutton.UseVisualStyleBackColor = true;
            this.BPGbutton.Click += new System.EventHandler(this.BPGbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Daykel_Marzo_FINALS_ProjectAssignment_STM.Properties.Resources.OIP__2_;
            this.pictureBox1.Location = new System.Drawing.Point(628, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PLAYERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 900);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BPGbutton);
            this.Controls.Add(this.SPGbutton);
            this.Controls.Add(this.BPGlistBox);
            this.Controls.Add(this.SPGlistBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.APGbutton);
            this.Controls.Add(this.APGlistBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RPGbutton);
            this.Controls.Add(this.RPGlistBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PPGbutton);
            this.Controls.Add(this.PPGlistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PLAYERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLAYERS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox PPGlistBox;
        private System.Windows.Forms.OpenFileDialog PointsPerGame;
        private System.Windows.Forms.Button PPGbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox RPGlistBox;
        private System.Windows.Forms.Button RPGbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox APGlistBox;
        private System.Windows.Forms.Button APGbutton;
        private System.Windows.Forms.OpenFileDialog ReboundsPerGame;
        private System.Windows.Forms.OpenFileDialog AssistsPerGame;
        private System.Windows.Forms.OpenFileDialog StealsPerGame;
        private System.Windows.Forms.OpenFileDialog BlocksPerGame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox SPGlistBox;
        private System.Windows.Forms.ListBox BPGlistBox;
        private System.Windows.Forms.Button SPGbutton;
        private System.Windows.Forms.Button BPGbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}