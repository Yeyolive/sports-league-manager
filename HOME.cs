using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Daykel_Marzo_FINALS_ProjectAssignment_STM
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();//Initializes everything you see on the form. 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //When Pressing the Back button, this is supposed to take you back to the MainFrom. 
            this.Close(); //Closes the form.
            MainForm openform = new MainForm(); //Opends the form.
            openform.Show(); //Shows the form. 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nba.com/news/warriors-stephen-curry-goes-off-for-49-points-in-29-minutes");
            //When link is clicked, it will take you to the displayed webpage in relation to the link.
            //Process start method provides the user with start methods to launch other applications, in this case, a link. 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nba.com/news/russell-westbrook-basks-in-milestone-moment");
            //When link is clicked, it will take you to the displayed webpage in relation to the link.
            //Process start method provides the user with start methods to launch other applications, in this case, a link. 
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nba.com/news/report-lebron-james-may-return-tuesday-vs-knicks");
            //When link is clicked, it will take you to the displayed webpage in relation to the link.
            //Process start method provides the user with start methods to launch other applications, in this case, a link. 
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nba.com/news/power-rankings-2020-21-week-21");
            //When link is clicked, it will take you to the displayed webpage in relation to the link.
            //Process start method provides the user with start methods to launch other applications, in this case, a link. 
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nba.com/news/power-rankings-notebook-best-offenses-most-improved-player");
            //When link is clicked, it will take you to the displayed webpage in relation to the link.
            //Process start method provides the user with start methods to launch other applications, in this case, a link. 
        }

        private void ViewPlayer(string Player)
        {
            switch (Player)
            {
                //This switch statement tests the Players variable and
               //branches to one of its case statements, depending on the variable’s value:
                case "STEPHEN CURRY": //In the case When the chosen is chosen.
                    ViewPlayerCURRY();//the chosen player is viewable. 
                    break; //This statement terminates the loop, and the program resumes at the next statement
                    //or loop. 
                case "NIKOLA JOKIC"://In the case When the chosen is chosen.
                    ViewPlayerJOKIC();//the chosen player is viewable.
                    break; //This statement terminates the loop, and the program resumes at the next statement
                           //or loop
                case "JOEL EMBIID"://In the case When the chosen is chosen.
                    ViewPlayerEMBIID();//the chosen player is viewable.
                    break; //This statement terminates the loop, and the program resumes at the next statement
                           //or loop
                case "GIANNIS ANTETOKOUNMPO"://In the case When the chosen is chosen.
                    ViewPlayerGIANNIS();//the chosen player is viewable.
                    break; //This statement terminates the loop, and the program resumes at the next statement
                           //or loop
                case "CHRIS PAUL"://In the case When the chosen is chosen.
                    ViewPlayerCP3();
                    break; //This statement terminates the loop, and the program resumes at the next statement
                    //or loop
            }
        }
        private void ViewPlayerCURRY()
        {
            //When true, the pictureBox is showed. 
            //When false, the pictureBox is hidden.
            CURRYpictureBox.Visible = true; 
            JOKICpictureBox.Visible = false;
            CP3pictureBox.Visible = false;
            EMBIIDpictureBox.Visible = false;
            GIANNISpictureBox.Visible = false;
            //When the user selects CURRY, The picturebox of CURRY will show
            //As its picture box value is true, and will be visible to the user.
        }
        private void ViewPlayerJOKIC()
        {
            //When true, the pictureBox is showed. 
            //When false, the pictureBox is hidden.
            CURRYpictureBox.Visible = false;
            JOKICpictureBox.Visible = true;
            CP3pictureBox.Visible = false;
            EMBIIDpictureBox.Visible = false;
            GIANNISpictureBox.Visible = false;
            //When the user selects JOKIC, The picturebox of JOKIC will show
            //As its picture box value is true, and will be visible to the user.
        }
        private void ViewPlayerCP3()
        {
            //When true, the pictureBox is showed. 
            //When false, the pictureBox is hidden.
            CURRYpictureBox.Visible = false;
            JOKICpictureBox.Visible = false;
            CP3pictureBox.Visible = true;
            EMBIIDpictureBox.Visible = false;
            GIANNISpictureBox.Visible = false;
            //When the user selects CHRIS PAUL, The picturebox of CHRIS PAUL will show
            //As its picture box value is true, and will be visible to the user.
        }
        private void ViewPlayerEMBIID()
        {
            //When true, the pictureBox is showed. 
            //When false, the pictureBox is hidden.
            CURRYpictureBox.Visible = false;
            JOKICpictureBox.Visible = false;
            CP3pictureBox.Visible = false;
            EMBIIDpictureBox.Visible = true;
            GIANNISpictureBox.Visible = false;
            //When the user selects EMBIID, The picturebox of EMBIID will show
            //As its picture box value is true, and will be visible to the user.
        }
        private void ViewPlayerGIANNIS() 
        {
            //When true, the pictureBox is showed. 
            //When false, the pictureBox is hidden.
            CURRYpictureBox.Visible = false;
            JOKICpictureBox.Visible = false;
            CP3pictureBox.Visible = false;
            EMBIIDpictureBox.Visible = false;
            GIANNISpictureBox.Visible = true;
            //When the user selects GIANNIS, The picturebox of Giannis will show
            //As its picture box value is true, and will be visible to the user.
        }

        private void ViewPlayersButton_Click(object sender, EventArgs e)
        {
            if (MVPraceListBox.SelectedIndex != -1) //determines whether the user has
                //selected an item in the mvp race list box control.
            {
                ViewPlayer(MVPraceListBox.SelectedItem.ToString()); //This statement gets the selected item from the ListBox
                //and assigns it to the players variable.
            }
            else
            {
                MessageBox.Show("Please Select A Player from the List Box!"); //If no player is chosen, this message will display.
            }
        }
        private void GetFileName(out string selectedFile) //Getfilename returns the file name or extracts file name 
        {
            if (TeamLebron.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = TeamLebron.FileName; //Contains the files name and information of the selected file. 
            }
            else //An alternative statement if the previous statement is false. 
            {
                selectedFile = ""; //Resets to clear the files name inside the listbox. 
            }
        }
        private void GetLebron(string TeamLebron)
        {
            try //Test the codeblock for any errors. 
            {
                string Lebron; //represents the text. 
                StreamReader inputFile; //This method is used to read the given character. 
                inputFile = File.OpenText(TeamLebron); //Opens an encoded text file. 
                TeamLebronListBox.Items.Clear(); //Clears all items inside the listbox. 

                while (!inputFile.EndOfStream)  //Gets the valuse to determine whether the current position
                    // is at the end of the stream. 
                {
                    Lebron = inputFile.ReadLine(); //Reads the next line of characters from the input stream. 
                    TeamLebronListBox.Items.Add(Lebron);
                }
            }
            catch (Exception) //It is used to catch an error when the program is running. 
            {
                MessageBox.Show("ERROR!"); //Displays an error when wrong information is entered.
            }
        }

        private void TeamLebronButton_Click(object sender, EventArgs e) 
        {
            string fileName; //identifies the filename stored within the system.
            GetFileName(out fileName); //specifies the output files name.
            GetLebron(fileName); //Sets the filesname within the given variable.
        }
        private void GetFileName2(out string selectedFile)//Getfilename returns the file name or extracts file name 
        {

            if (TeamDurant.ShowDialog() == DialogResult.OK) //This is the Value returned from the form.
            {
                selectedFile = TeamDurant.FileName;//Contains the files name and information of the selected file.
            }
            else//An alternative statement if the previous statement is false. 
            {
                selectedFile = ""; //Clears anything in the listbox.
            }
        }
        private void GetDurant(string TeamDurant)
        {
            try//Test the codeblock for any errors.
            {
                string Durant;//represents the text.
                StreamReader inputFile;//This method is used to read the given character. 
                inputFile = File.OpenText(TeamDurant);//Opens an encoded text file.
                TeamDurantListBox.Items.Clear();//Clears all items inside the listbox. 

                while (!inputFile.EndOfStream) //Executes the statement repeatedly until the end of the file.
                {
                    Durant = inputFile.ReadLine(); //Returns one line to the file. 
                    TeamDurantListBox.Items.Add(Durant);//Adds the text.
                }
            }
            catch (Exception)//determine or search for any errors.
            {
                MessageBox.Show("ERROR!");//if an error is made, this will be displayed.
            }
        }

        private void TeamDurantButton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName2(out fileName);//specifies the output files name.
            GetDurant(fileName);//Sets the filesname within the given variable.
        }
    }
}
