using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daykel_Marzo_FINALS_ProjectAssignment_STM
{
    public partial class LoadingForm : Form
    //This From will appear as a Loading screen, directing you to the next forms within this application.
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void SpanishButton_Click(object sender, EventArgs e)
        {
            Translationlabel.Text = "Bienvenidos a La NBA!";
            //Translates the caption welcome to the NBA to spanish. 
        }

        private void FrenchButton_Click(object sender, EventArgs e)
        {
            Translationlabel.Text = "Bienvenue Dans La NBA!";
            //Translates the caption welcome to the NBA to French. 
        }

        private void ItalianButton_Click(object sender, EventArgs e)
        {
            Translationlabel.Text = "Benvenuti Nella NBA!";
            //Translates the caption welcome to the NBA to Italian. 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Is the NBA Logo!");
            //When the picture of the NBA is clicked, the user should know what the logo stands for and what it is.
        }
        int Startpoint = 0; //The loading progress startpoint. 
        private void timer1_Tick(object sender, EventArgs e)
        {
            Startpoint += 1; //This increases the starting point by one as the progress goes on. 
            progressBar.Value = Startpoint; //The Startpoint is the value of the progressbar. 
            if (progressBar.Value == 100) 
            {
                //When progressbar has reached its maximum displayed value, it goes back to 0, and
                //the timer stops. 
                progressBar.Value = 0;
                timer1.Stop(); 
                MainForm log = new MainForm();
                this.Hide();
                log.Show();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //Timer begins loading the form. 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This is in case the user decides to skip the loading progress.
            MainForm openform = new MainForm();
            openform.Show();
        }
    }
}
