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
    public partial class MORE : Form
    {
        public MORE()
        {
            InitializeComponent();//Initializes everything you see on the form.
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            AnswertextBox.Text = "Dr. James Naismith";//Displays the given answer within the textbox.
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            AnswertextBox.Text = "";//Clears the textbox's text. 
        }

        private void CalculateStatsButton_Click(object sender, EventArgs e)
        {
                //Variables. 
                double Games1;
                double Points;
                double PPG;

                //Get points per game from the text boxes. 
                Games1 = double.Parse(GamestextBox.Text);
                Points = double.Parse(PointstextBox.Text);
                PPG = Points/Games1;
                PPGtextBox.Text = PPG.ToString("n1");

            //Calculate and use logic operators to determine different Points per game outcomes. 
            if ((PPG <= 20.0) && (PPG <= 23.0))
            {
                MessageBox.Show("You are a Good Scorer!");//if condition is true, this message  will be displayed.
            }
            else if ((PPG >= 23.1) && (PPG <= 29.0))
                {
                    MessageBox.Show("You are a great Scorer!");//if condition is true, this message  will be displayed.
            }
            else if ((PPG >= 29.1) && (PPG <= 32))
            {
                MessageBox.Show("You are an ELITE Scorer!");//if condition is true, this message  will be displayed.
            }
            else if ((PPG > 32.1) && (PPG <= 40.0 ))
            {
                MessageBox.Show("You are a Legendary Scorer!!");//if condition is true, this message  will be displayed.
            }
            else if (PPG > 40.1)
            {
                MessageBox.Show("Your an ALIEN SCORER!!");//if condition is true, this message  will be displayed.
            }
            else//An alternative incase the previous conditions are false.
            {
                MessageBox.Show("Please Enter your desired numbers in integers, for each TextBox!");
                //if condition is true, this message  will be displayed.
            }
        }
        

        private void CalcuateReboundsbutton_Click(object sender, EventArgs e)
        {
            //Variables
            double Games2;
            double Rebounds;
            double RPG;


            //Get Rebounds per game from the text boxes. 
            Games2 = double.Parse(GamestextBox2.Text);
            Rebounds = double.Parse(ReboundstextBox.Text);
            RPG = (Rebounds / Games2);
            RPGtextBox.Text = RPG.ToString("n1");

            //Calculate and use logic operators to determine different Rebounds per game outcomes. 
            if (RPG <= 5.0)
            {
                MessageBox.Show("You are a Good Rebounder!");//if condition is true, this message  will be displayed.
            }
            else if ((RPG >= 6.0) && (RPG <= 8.0))
            {
                MessageBox.Show("You are a great Rebounder!");//if condition is true, this message  will be displayed.
            }
            else if ((RPG >= 9.0) && (RPG <= 14))
            {
                MessageBox.Show("You are an ELITE Rebounder!");//if condition is true, this message  will be displayed.
            }
            else if ((RPG > 15.0) && (RPG <= 20.0))
            {
                MessageBox.Show("You are a Legendary Rebounder!!");//if condition is true, this message  will be displayed.
            }
            else if (RPG > 20.0)
            {
                MessageBox.Show("your an ALIEN REBOUNDER!!");//if condition is true, this message  will be displayed.
            }
            else//An alternative incase the previous conditions are false.
            { 
                    MessageBox.Show("Please Enter your desired numbers in integers, for each TextBox!");
                //This message  will be displayed.
            }
        }

        private void CalculateAssistsbutton_Click(object sender, EventArgs e)
        {
            //Variables
            double Games3;
            double Assists;
            double APG;


            //Get Rebounds per game from the text boxes. 
            Games3 = double.Parse(GamestextBox3.Text);
            Assists = double.Parse(AssiststextBox.Text);
            APG = (Assists / Games3);
            APGtextBox.Text = APG.ToString("n1");

            //Calculate and use logic operators to determine different Rebounds per game outcomes. 
            if (APG <= 5.0)
            {
                MessageBox.Show("You are a Good Passer!");//if condition is true, this message  will be displayed.
            }
            else if ((APG >= 6.0) && (APG <= 7.0))
            {
                MessageBox.Show("You are a great Passer!");//if condition is true, this message  will be displayed.
            }
            else if ((APG >= 8.0) && (APG <= 9))
            {
                MessageBox.Show("You are an ELITE passer!");//if condition is true, this message  will be displayed.
            }
            else if ((APG > 10.0) && (APG <= 15.0))
            {
                MessageBox.Show("You are a Legendary passer!!");//if condition is true, this message  will be displayed.
            }
            else if (APG > 15.0)
            {
                MessageBox.Show("your an ALIEN Passer!!");//if condition is true, this message  will be displayed.
            }
            else//An alternative incase the previous conditions are false.
            {
                MessageBox.Show("Please Enter your desired numbers in integers, for each TextBox!");
                //This message  will be displayed.
            }
        }

        private void ClearButton4_Click(object sender, EventArgs e)
        {
            //Clears everything with in each given textbox.
            GamestextBox.Text = "";
            GamestextBox2.Text = "";
            GamestextBox3.Text = "";
            //Clears everything with in each given textbox.
            ReboundstextBox.Text = "";
            PointstextBox.Text = "";
            AssiststextBox.Text = "";
            //Clears everything with in each given textbox.
            PPGtextBox.Text = "";
            RPGtextBox.Text = "";
            APGtextBox.Text = "";
        }

        int GAMES;
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(GamesplayedTextBox.Text, out GAMES))
            {
                if ((GAMES > 0) && (GAMES <= 39))//This statement depending on the games played, will run depending on its condition.
                {
                    MessageBox.Show("You have played a few games!");//Displays a message when the requirements are met within the statement.
                }
                if ((GAMES > 39) && (GAMES <= 41))//This statement depending on the games played, will run depending on its condition.
                {
                    MessageBox.Show("You have played half of the NBA Games!");//Displays a message when the requirements are met within the statement.
                }
                if ((GAMES > 41) && (GAMES <= 60))//This statement depending on the games played, will run depending on its condition.
                {
                    MessageBox.Show("Great! You have played most of the NBA Games! ");//Displays a message when the requirements are met within the statement.
                }
                if ((GAMES > 60) && (GAMES <= 70))//This statement depending on the games played, will run depending on its condition.
                {
                    MessageBox.Show("You are a Machine!");//Displays a message when the requirements are met within the statement.
                }
                if ((GAMES > 70) && (GAMES <= 82))//This statement depending on the games played, will run depending on its condition.
                {
                    MessageBox.Show("YOU WERE MADE FOR THIS!!");//Displays a message when the requirements are met within the statement.
                }
                if (GAMES > 0 && GAMES <= 82)//This statement depending on the games played, will run depending on its condition.
                {
                    //Continue to process the input. 
                }
                else//This is an alternative statement in case the condition is false.
                {
                    MessageBox.Show(" 82 Games per year is the Maximum. Invalid numbers of Games entered");
                    //this message  will be displayed, if previous conditions are false.
                }
            }
            else//This is an alternative statement in case the condition is false.
            {
                MessageBox.Show(" Games entered must be an integer");
                //this message will be displayed, if previous conditions are false.
            }
        }

        private void AnswerButton2_Click(object sender, EventArgs e)
        {
            AnswertextBox2.Text = "30 Teams!";//Displays the given text within the texbox, in the message box.
        }

        private void ClearbuttonTeams_Click(object sender, EventArgs e)
        {
            AnswertextBox2.Text = "";//Clears everything within the textbox.
        }

        private void Answerbutton3_Click(object sender, EventArgs e)
        {
            textBoxHMG.Text = "82 Games are played";//Displays the given text within the texbox, in the message box.
        }

        private void ClearButtonHMG_Click(object sender, EventArgs e)
        {
            textBoxHMG.Text = "";//Clears everything within the textbox.
        }

        private void Answerbutton4_Click(object sender, EventArgs e)
        {
            GOATtextBox.Text = " MICHAEL JORDAN";//Displays the given text within the texbox, in the message box.
        }

        private void ClearButtonGOAT_Click(object sender, EventArgs e)
        {
            GOATtextBox.Text = "";//Clears everything within the textbox.
        }

        private void mjbutton_Click(object sender, EventArgs e)
        {
            MJtextBox1.Text = "The Chicago Bulls!";//Displays the given text within the texbox, in the message box.
        }

        private void mjclearbutton_Click(object sender, EventArgs e)
        {
            MJtextBox1.Text = "";//Clears everything within the textbox.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is MICHAEL JORDAN!");//Displays the given text within the texbox, in the message box.
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Michael Jordan Played for this team!");//Displays the given text within the texbox, in the message box.
        }

        private void ClearButtonGP_Click(object sender, EventArgs e)
        {
            GamesplayedTextBox.Text = "";//Clears everything within the textbox.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MORE_secondpage openform = new MORE_secondpage();//Declares which form is to be opened.
            openform.Show(); //opens or shows the indicated form.
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //When Pressing the Back button, this is supposed to take you back to the Mainform.
            this.Close();//closes the form.
            MainForm openform = new MainForm();//Declares which new form is to be opened.
            openform.Show();//Displays or shows the form given.
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
