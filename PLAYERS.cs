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

namespace Daykel_Marzo_FINALS_ProjectAssignment_STM
{
    public partial class PLAYERS : Form
    {
        public PLAYERS()
        {
            InitializeComponent();//Initializes everything you see on the form. 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //When Pressing the Back button, this is supposed to take you back to the MainFrom.
            this.Close(); //Closes the form
            MainForm openform = new MainForm();//Declares which new form is to be opened.
            openform.Show(); //opens or shows the indicated form.
        }
        private void GetFileName(out string selectedFile) //Getfilename returns the file name or extracts file name 
        {
            if (PointsPerGame.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = PointsPerGame.FileName; //Contains the files name and information of the selected file. 
            }
            else//An alternative statement if the previous statement is false.
            {
                selectedFile = ""; //Resets to clear the files name inside the listbox. 
            }
        }
        private void GetPoints(string PointsPerGame)
        {
            try//statement made to test for errors while being executed.
            {
                string Points; //represents the text. 
                StreamReader inputFile; //This method is used to read the given character. 
                inputFile = File.OpenText(PointsPerGame); //Opens an encoded text file. 
                PPGlistBox.Items.Clear(); //Clears all items inside the listbox. 

                while (!inputFile.EndOfStream)  //Gets the valuse to determine whether the current position
                                                // is at the end of the stream. 
                {
                    Points = inputFile.ReadLine(); //Reads the next line of characters from the input stream. 
                    PPGlistBox.Items.Add(Points);//Adds items into the listbox.
                }
            }
            catch (Exception) //It is used to catch an error when the program is running. 
            {
                MessageBox.Show("ERROR!");//If an error is produced, this message will be displayed.
            }
        }
        private void PPGbutton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName(out fileName);//specifies the output files name.
            GetPoints(fileName);//Sets the filesname within the given variable.
        }

        private void GetFileName2(out string selectedFile) //Getfilename returns the file name or extracts file name 
        {
            if (ReboundsPerGame.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = ReboundsPerGame.FileName; //Contains the files name and information of the selected file. 
            }
            else//An alternative statement if the previous statement is false. 
            {
                selectedFile = ""; //Resets to clear the files name inside the listbox. 
            }
        }
        private void GetRebounds(string ReboundsPerGame)
        {
            try//Test the codeblock for any errors.
            {
                string Rebounds; //represents the text. 
                StreamReader inputFile; //This method is used to read the given character. 
                inputFile = File.OpenText(ReboundsPerGame); //Opens an encoded text file. 
                RPGlistBox.Items.Clear(); //Clears all items inside the listbox. 

                while (!inputFile.EndOfStream)  //Gets the valuse to determine whether the current position
                                                // is at the end of the stream. 
                {
                    Rebounds = inputFile.ReadLine(); //Reads the next line of characters from the input stream. 
                    RPGlistBox.Items.Add(Rebounds);//Adds items into the listbox.
                }
            }
            catch (Exception) //It is used to catch an error when the program is running. 
            {
                MessageBox.Show("ERROR!");//Displays an error message. 
            }
        }
        private void RPGbutton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName2(out fileName);//specifies the output files name.
            GetRebounds(fileName);//Sets the filesname within the given variable.
        }
        private void GetFileName3(out string selectedFile) //Getfilename returns the file name or extracts file name 
        {
            if (AssistsPerGame.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = AssistsPerGame.FileName; //Contains the files name and information of the selected file. 
            }
            else//An alternative statement if the previous statement is false. 
            {
                selectedFile = ""; //Resets to clear the files name inside the listbox. 
            }
        }
        private void GetAssists(string AssistsPerGame)//Getfilename returns the file name or extracts file name 
        {
            try//Test the codeblock for any errors.
            {
                string Assists; //represents the text. 
                StreamReader inputFile; //This method is used to read the given character. 
                inputFile = File.OpenText(AssistsPerGame); //Opens an encoded text file. 
                APGlistBox.Items.Clear(); //Clears all items inside the listbox. 

                while (!inputFile.EndOfStream)  //Gets the valuse to determine whether the current position
                                                // is at the end of the stream. 
                {
                    Assists = inputFile.ReadLine(); //Reads the next line of characters from the input stream. 
                    APGlistBox.Items.Add(Assists);//Adds items into the listbox.
                }
            }
            catch (Exception) //It is used to catch an error when the program is running. 
            {
                MessageBox.Show("ERROR!");//Displays an error message
            }
        }

        private void APGbutton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName3(out fileName);//specifies the output files name.
            GetAssists(fileName);//Sets the filesname within the given variable.
        }
        private void GetFileName4(out string selectedFile) //Getfilename returns the file name or extracts file name 
        {
            if (StealsPerGame.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = StealsPerGame.FileName; //Contains the files name and information of the selected file. 
            }
            else
            {
                selectedFile = ""; //Resets to clear the files name inside the listbox. 
            }
        }
        private void GetSteals(string StealsPerGame)//Getfilename returns the file name or extracts file name 
        {
            try//Test the codeblock for any errors.
            {
                string Steals; //represents the text. 
                StreamReader inputFile; //This method is used to read the given character. 
                inputFile = File.OpenText(StealsPerGame); //Opens an encoded text file. 
                SPGlistBox.Items.Clear(); //Clears all items inside the listbox. 

                while (!inputFile.EndOfStream)  //Gets the valuse to determine whether the current position
                                                // is at the end of the stream. 
                {
                    Steals = inputFile.ReadLine(); //Reads the next line of characters from the input stream. 
                    SPGlistBox.Items.Add(Steals);//Adds items into the listbox.
                }
            }
            catch (Exception) //It is used to catch an error when the program is running. 
            {
                MessageBox.Show("ERROR!");//Displays an error message
            }
        }
        private void SPGbutton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName4(out fileName);//specifies the output files name.
            GetSteals(fileName);//Sets the filesname within the given variable.
        }
        private void GetFileName5(out string selectedFile) //Getfilename returns the file name or extracts file name 
        {
            if (BlocksPerGame.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = BlocksPerGame.FileName; //Contains the files name and information of the selected file. 
            }
            else
            {
                selectedFile = ""; //Resets to clear the files name inside the listbox. 
            }
        }
        private void GetBlocks(string BlocksPerGame)//Getfilename returns the file name or extracts file name 
        {
            try//Test the codeblock for any errors.
            {
                string Blocks; //represents the text. 
                StreamReader inputFile; //This method is used to read the given character. 
                inputFile = File.OpenText(BlocksPerGame); //Opens an encoded text file. 
                BPGlistBox.Items.Clear(); //Clears all items inside the listbox. 

                while (!inputFile.EndOfStream)  //Gets the valuse to determine whether the current position
                                                // is at the end of the stream. 
                {
                    Blocks = inputFile.ReadLine(); //Reads the next line of characters from the input stream. 
                    BPGlistBox.Items.Add(Blocks); //
                }
            }
            catch (Exception) //It is used to catch an error when the program is running. 
            {
                MessageBox.Show("ERROR!");// Displayes an error message in case of an error 
            }
        }
            private void BPGbutton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName5(out fileName);//specifies the output files name.
            GetBlocks(fileName);//Sets the filesname within the given variable.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Lebron James!");//Displays the name of the player in the image.
        }
    }
}

