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
    public partial class MainForm : Form //This From displays the main functions of this application. 
    {
        public MainForm()
        {
            InitializeComponent(); //Initializes the form.
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            //This Opens The Form HOME, when the HOME button is clicked. 
            HOME openform = new HOME();
            openform.Show();
        }

        private void StandingsButton_Click(object sender, EventArgs e)
        {
            //When Standings Button is clicked, the form STANDINGS displays. 
            STANDINGS Openform = new STANDINGS();
            Openform.Show();

        }

        private void GamesButton_Click(object sender, EventArgs e)
        {
            //When Games button is clicked, the form GAMES opens right after. 
            GAMES openform = new GAMES();
            openform.Show();
        }

        private void PlayersButton_Click(object sender, EventArgs e)
        {
            //When Players button is clicked, the form PLAYERS should display.
            PLAYERS openform = new PLAYERS();
            openform.Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //When Next button is clicked, the form MORE should display.
            MORE openform = new MORE();//Declares the form to be opened/
            openform.Show();//Opens the form, or shows it.
        }

        private void REDradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (REDradioButton.Checked) //Ivaluates if condition is true, and Checks the selected RadioButton.
            {
                this.BackColor = Color.Red; //Switches the background color to the chosen color.
            }
        }

        private void MIDNIGHTBLUEradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MIDNIGHTBLUEradioButton.Checked)//Ivaluates if the condition is true, and Checks the selected RadioButton.
            {
                this.BackColor = Color.MidnightBlue; //Switches the background color to the chosen color.
            }
        }

        private void ORANGEradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ORANGEradioButton.Checked)//Ivaluates if statement is true, and Checks the selected RadioButton.
            {
                this.BackColor = Color.Orange; //Switches the background color to the chosen color.
            }
        }

        private void YELLOWradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YELLOWradioButton.Checked)//Ivaluates if statement is true, and Checks the selected RadioButton.
            {
                this.BackColor = Color.Yellow; //Switches the background color to the chosen color.
            }
        }

        private void GREENradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GREENradioButton.Checked)//Ivaluates if statement is true, and Checks the selected RadioButton.
            {
                this.BackColor = Color.Green; //Switches the background color to the chosen color.
            }
        }

        private void PURPLEradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PURPLEradioButton.Checked)//Ivaluates if statement is true, and Checks the selected RadioButton.
            {
                this.BackColor = Color.Purple; //Switches the background color to the chosen color.
            }
        }

        private void ACTIVEradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MAROONradioButton.Checked)//Ivaluates if statement is true, and Checks the selected RadioButton.
            {
                this.BackColor = Color.Maroon; //Switches the background color to the chosen color.
            }
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();//Closes the form.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
