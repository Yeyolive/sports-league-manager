
namespace Daykel_Marzo_FINALS_ProjectAssignment_STM
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpanishButton = new System.Windows.Forms.Button();
            this.FrenchButton = new System.Windows.Forms.Button();
            this.ItalianButton = new System.Windows.Forms.Button();
            this.Translationlabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Daykel_Marzo_FINALS_ProjectAssignment_STM.Properties.Resources.NBA_LOGOOO;
            this.pictureBox1.Location = new System.Drawing.Point(177, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To The NBA!";
            // 
            // SpanishButton
            // 
            this.SpanishButton.Location = new System.Drawing.Point(12, 182);
            this.SpanishButton.Name = "SpanishButton";
            this.SpanishButton.Size = new System.Drawing.Size(75, 32);
            this.SpanishButton.TabIndex = 3;
            this.SpanishButton.Text = "Spanish";
            this.SpanishButton.UseVisualStyleBackColor = true;
            this.SpanishButton.Click += new System.EventHandler(this.SpanishButton_Click);
            // 
            // FrenchButton
            // 
            this.FrenchButton.Location = new System.Drawing.Point(12, 216);
            this.FrenchButton.Name = "FrenchButton";
            this.FrenchButton.Size = new System.Drawing.Size(75, 32);
            this.FrenchButton.TabIndex = 4;
            this.FrenchButton.Text = "French";
            this.FrenchButton.UseVisualStyleBackColor = true;
            this.FrenchButton.Click += new System.EventHandler(this.FrenchButton_Click);
            // 
            // ItalianButton
            // 
            this.ItalianButton.Location = new System.Drawing.Point(12, 254);
            this.ItalianButton.Name = "ItalianButton";
            this.ItalianButton.Size = new System.Drawing.Size(75, 32);
            this.ItalianButton.TabIndex = 5;
            this.ItalianButton.Text = "Italian";
            this.ItalianButton.UseVisualStyleBackColor = true;
            this.ItalianButton.Click += new System.EventHandler(this.ItalianButton_Click);
            // 
            // Translationlabel
            // 
            this.Translationlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Translationlabel.Location = new System.Drawing.Point(12, 109);
            this.Translationlabel.Name = "Translationlabel";
            this.Translationlabel.Size = new System.Drawing.Size(107, 70);
            this.Translationlabel.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar.ForeColor = System.Drawing.Color.Blue;
            this.progressBar.Location = new System.Drawing.Point(-8, 292);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(507, 23);
            this.progressBar.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "SKIP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Daykel_Marzo_FINALS_ProjectAssignment_STM.Properties.Resources.Brooklyn_Nets_v_Toronto_Raptors___Game_One_479689e947063c768131aa425b6b74e6;
            this.ClientSize = new System.Drawing.Size(489, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Translationlabel);
            this.Controls.Add(this.ItalianButton);
            this.Controls.Add(this.FrenchButton);
            this.Controls.Add(this.SpanishButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports League Management(NBA)";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SpanishButton;
        private System.Windows.Forms.Button FrenchButton;
        private System.Windows.Forms.Button ItalianButton;
        private System.Windows.Forms.Label Translationlabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

