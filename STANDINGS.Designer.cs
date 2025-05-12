
namespace Daykel_Marzo_FINALS_ProjectAssignment_STM
{
    partial class STANDINGS
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
            this.EASTERNconferenceListBox = new System.Windows.Forms.ListBox();
            this.WESTERNconferenceListBox = new System.Windows.Forms.ListBox();
            this.WESTERNconferenceButton = new System.Windows.Forms.Button();
            this.EASTERNconferenceButton = new System.Windows.Forms.Button();
            this.EASTERNconference = new System.Windows.Forms.OpenFileDialog();
            this.WESTERNconference = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(671, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 41);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "NBA STANDINGS 2021";
            // 
            // EASTERNconferenceListBox
            // 
            this.EASTERNconferenceListBox.FormattingEnabled = true;
            this.EASTERNconferenceListBox.ItemHeight = 16;
            this.EASTERNconferenceListBox.Location = new System.Drawing.Point(28, 108);
            this.EASTERNconferenceListBox.Name = "EASTERNconferenceListBox";
            this.EASTERNconferenceListBox.Size = new System.Drawing.Size(343, 228);
            this.EASTERNconferenceListBox.TabIndex = 3;
            // 
            // WESTERNconferenceListBox
            // 
            this.WESTERNconferenceListBox.FormattingEnabled = true;
            this.WESTERNconferenceListBox.ItemHeight = 16;
            this.WESTERNconferenceListBox.Location = new System.Drawing.Point(399, 108);
            this.WESTERNconferenceListBox.Name = "WESTERNconferenceListBox";
            this.WESTERNconferenceListBox.Size = new System.Drawing.Size(343, 228);
            this.WESTERNconferenceListBox.TabIndex = 4;
            // 
            // WESTERNconferenceButton
            // 
            this.WESTERNconferenceButton.Location = new System.Drawing.Point(482, 373);
            this.WESTERNconferenceButton.Name = "WESTERNconferenceButton";
            this.WESTERNconferenceButton.Size = new System.Drawing.Size(176, 46);
            this.WESTERNconferenceButton.TabIndex = 7;
            this.WESTERNconferenceButton.Text = "WESTERN CONFERENCE";
            this.WESTERNconferenceButton.UseVisualStyleBackColor = true;
            this.WESTERNconferenceButton.Click += new System.EventHandler(this.WESTERNconferenceButton_Click);
            // 
            // EASTERNconferenceButton
            // 
            this.EASTERNconferenceButton.Location = new System.Drawing.Point(113, 373);
            this.EASTERNconferenceButton.Name = "EASTERNconferenceButton";
            this.EASTERNconferenceButton.Size = new System.Drawing.Size(176, 46);
            this.EASTERNconferenceButton.TabIndex = 8;
            this.EASTERNconferenceButton.Text = "EASTERN CONFERENCE";
            this.EASTERNconferenceButton.UseVisualStyleBackColor = true;
            this.EASTERNconferenceButton.Click += new System.EventHandler(this.EASTERNbutton_Click);
            // 
            // EASTERNconference
            // 
            this.EASTERNconference.FileName = "EASTERNconference";
            // 
            // WESTERNconference
            // 
            this.WESTERNconference.FileName = "WESTERNconference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "EASTERN CONFERENCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "WESTERN CONFERENCE";
            // 
            // STANDINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EASTERNconferenceButton);
            this.Controls.Add(this.WESTERNconferenceButton);
            this.Controls.Add(this.WESTERNconferenceListBox);
            this.Controls.Add(this.EASTERNconferenceListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STANDINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STANDINGS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EASTERNconferenceListBox;
        private System.Windows.Forms.ListBox WESTERNconferenceListBox;
        private System.Windows.Forms.Button WESTERNconferenceButton;
        private System.Windows.Forms.Button EASTERNconferenceButton;
        private System.Windows.Forms.OpenFileDialog EASTERNconference;
        private System.Windows.Forms.OpenFileDialog WESTERNconference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}