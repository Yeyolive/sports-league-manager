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
    public partial class MOREthirdpage : Form
    {
        public MOREthirdpage()
        {
            InitializeComponent();//Initializes everything you see on the form.
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();//closes the form.
            MORE_secondpage openform = new MORE_secondpage();//Declares which form is to be displayed.
            openform.Show();//opens the given form.
        }

        private void GetNamesButton_Click(object sender, EventArgs e)
        {
            //variables
            const int SIZE = 3;//this is a pointer, this value is not changed.
            string[] names = new string[SIZE];//creates a new object.

            //Declares the variables to be displayed as text, out in the given textbox.
            names[0] = nametextBox1.Text;
            names[1] = nametextBox2.Text;
            names[2] = nametextBox3.Text;
            //Display the give strings within the message box.
            MessageBox.Show(names[0]);
            MessageBox.Show(names[1]);
            MessageBox.Show(names[2]);

        }

        private void WriteNamebutton_Click(object sender, EventArgs e)
        {
            try //catch any exceptions or erros. 
            {
                StreamWriter outputFile;//Reads the given file. 

                outputFile = File.CreateText("FavoriteNBAPlayer'sName.Text");//creates new file with the specified contents.

                outputFile.WriteLine(NAMEtextBox.Text);//reads what is written within the textbox.

                outputFile.Close();//closes the file.

                MessageBox.Show("The Name was written!");//lets you know if name was written.
            }
            catch (Exception ex)//defines the block of code to be executed in case an error occurs.
            {
                MessageBox.Show(ex.Message);//shows the exception or error message.
            }
        }

        private void SWITCHbutton_Click(object sender, EventArgs e)
        {
            //varibles.
            int Switch;

            Random rand = new Random();//creates an array of the given object, displaying it randomly. 

            Switch = rand.Next(2);//returns the random integer within the given range which is 2.

            if (Switch == 0)//performs the action if proved true.
            {
                NBApictureBox.Visible = true;//this will be displayed.
                STREETpictureBox.Visible = false;//this won't be displayed.
            }
            else//alternative in case the if statement is fale. 
            {
                STREETpictureBox.Visible = true;//this will be displayed.
                NBApictureBox.Visible = false;//this won't be displayed.
            }
        }

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            //Clears everything within the textbbox.
            nametextBox1.Text = "";
            nametextBox2.Text = "";
            nametextBox3.Text = "";
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            //Clears everything within the textbox.
            NAMEtextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
