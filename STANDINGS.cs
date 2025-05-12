using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daykel_Marzo_FINALS_ProjectAssignment_STM
{
    public partial class STANDINGS : Form
    {
        public STANDINGS()
        {
            InitializeComponent();//Initializes everything you see on the form. 
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //When Pressing the Back button, this is supposed to take you back to the MainFrom.
            this.Close();//Closes the form.
            MainForm openform = new MainForm();//Opens the form.
            openform.Show();//Shows the form.
        }

        private void EASTERNbutton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName(out fileName);//specifies the output files name.
            GetEASTERN(fileName);//Sets the filesname within the given variable.
        }
        private void GetFileName(out string selectedFile) //Getfilename returns the file name or extracts file name 
        {
            if (EASTERNconference.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = EASTERNconference.FileName; //Contains the files name and information of the selected file.
            }
            else//An alternative statement if the previous statement is false. 
            {
                selectedFile = "";//Resets to clear the files name inside the listbox. 
            }
        }
        private void GetEASTERN(string EASTERNconference)
        {
            try//statement made to test for errors while being executed.
            {
                string EASTERN; //represents the text. 
                StreamReader inputFile; //This method is used to read the given character. 
                inputFile = File.OpenText(EASTERNconference); //Opens an encoded text file. 
                EASTERNconferenceListBox.Items.Clear(); //Clears all items inside the listbox. 

                while (!inputFile.EndOfStream)//Gets the valuse to determine whether the current position
                                              // is at the end of the stream.
                {
                    EASTERN = inputFile.ReadLine(); //Reads the next line of characters from the input stream.
                    EASTERNconferenceListBox.Items.Add(EASTERN);//Adds items into the listbox.
                }
            }
            catch (Exception)//determine or search for any errors.
            {
                MessageBox.Show("ERROR!"); //If an error is produced, this message will be displayed.
            }
        }

        private void WESTERNconferenceButton_Click(object sender, EventArgs e)
        {
            string fileName;//identifies the filename stored within the system.
            GetFileName(out fileName);//specifies the output files name.
            GetWESTERN(fileName);//Sets the filesname within the given variable.
        }
        private void GetFileName2(out string selectedFile)
        {
            if (WESTERNconference.ShowDialog() == DialogResult.OK)//This is the Value returned from the form.
            {
                selectedFile = WESTERNconference.FileName;//Contains the files name and information of the selected file.
            }
            else//An alternative statement if the previous statement is false. 
            {
                selectedFile = "";//Clears anything in the listbox.
            }
        }
        private void GetWESTERN(string WESTERNconference)
        {
            try//Test the codeblock for any errors.
            {
                string WESTERN; //holds or declares a variable to hold the western conference name. 
                StreamReader inputFile; //declares a streamreader. 
                inputFile = File.OpenText(WESTERNconference); //File is to open and get a streamrader object.
                WESTERNconferenceListBox.Items.Clear(); //Clear anything in the listbox. 

                while (!inputFile.EndOfStream) //Reads the files contents. 
                {
                    WESTERN = inputFile.ReadLine(); //Gets the conference name. 
                    WESTERNconferenceListBox.Items.Add(WESTERN); //Adds the conference name to the listbox. 
                }
            }
            catch (Exception)//determine or search for any errors.
            {
                MessageBox.Show("ERROR!"); //Displays an error message. 
            }
        }
    }
}
