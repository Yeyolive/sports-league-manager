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
    public partial class MORE_secondpage : Form
    {
        public MORE_secondpage()
        {
            InitializeComponent();//Initializes everything you see on the form.
        }
        //variables
        int Dunk;
        int ThreePointer;
        int MidRange;
        int Freethrow;
        int CloseShot;
        int Overall;

        private void OverallButton_Click(object sender, EventArgs e)
        {
            // //converts the string representation into its integer number equivalent.
            Dunk = int.Parse(DunktextBox.Text);
            ThreePointer = int.Parse(ThreepointertextBox.Text);
            MidRange = int.Parse(MidRangetextBox.Text);
            Freethrow = int.Parse(FreeThrowtextBox.Text);
            CloseShot = int.Parse(CloseShottextBox.Text);
            Overall = (Dunk + ThreePointer + MidRange + Freethrow + CloseShot) / 5;
            PlayerOveralltextBox.Text = Overall.ToString("n1");
            //converts the given object to the given string, displaying the outcome in currency.

            if ((Overall <= 69))////Calculate and use logic operators to determine different overall outcomes. 
            {
                MessageBox.Show(" You Are still a Street baller! ");//if condition is true, this message  will be displayed.
            }
            else if ((Overall > 70) && (Overall <= 78))
            {
                MessageBox.Show("You are now an NBA Rookie!");//if condition is true, this message  will be displayed.
            }
            else if ((Overall > 78) && (Overall <= 85))
            {
                MessageBox.Show("You Are now an NBA Star!");//if condition is true, this message  will be displayed.
            }
            else if ((Overall > 85) && (Overall <= 90))
            {
                MessageBox.Show(" You Are now an NBA All-Star!");//if condition is true, this message  will be displayed.
            }
            else if ((Overall > 90) && (Overall <= 94))
            {
                MessageBox.Show(" You Are now an NBA Super-Star!");//if condition is true, this message  will be displayed.
            }
            else if ((Overall > 94) && (Overall <= 99))
            {
                MessageBox.Show(" YOU ARE NOW AN NBA LEGEND!!!");//if condition is true, this message  will be displayed.
            }
            else if ((Overall > 99))
            {
                MessageBox.Show(" This is ALIEN Level, STOP IT!");//if condition is true, this message  will be displayed.
            }
        }
        //variable.
        double NbaAverageYearsplayed;
        double NbaAverageSalary;
        double NbaAverageNetWorth;

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //converts the string representation into its double number equivalent.
            NbaAverageYearsplayed = double.Parse(AVGyearstextBox.Text);
            NbaAverageSalary = double.Parse(AVGsalarytextBox.Text);
            NbaAverageNetWorth = NbaAverageYearsplayed * NbaAverageSalary;
            AVGnetworthtextBox.Text = NbaAverageNetWorth.ToString("c");
            //converts the given object to the given string, displaying the outcome in currency.
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            //Clears all texts within the textbox.
            AVGyearstextBox.Text = "";
            AVGsalarytextBox.Text = "";
            AVGnetworthtextBox.Text = "";
        }

        private void Answerbuttontrophy_Click(object sender, EventArgs e)
        {
            //Displays the answer, within the textbox.
            TrophytextBox.Text = "The Larry O’Brien trophy";
        }

        private void Clearbuttontrophy_Click(object sender, EventArgs e)
        {
            //Clears the text within the texbox.
            TrophytextBox.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();//Closes the form.
            MORE openform = new MORE();//declares which form is to open.
            openform.Show();//openss the given form.
        }

        private void ClearButton3_Click(object sender, EventArgs e)
        {
            //clears all text within the textbox.
            DunktextBox.Text = "";
            ThreepointertextBox.Text = "";
            MidRangetextBox.Text = "";
            CloseShottextBox.Text = "";
            FreeThrowtextBox.Text = "";
            PlayerOveralltextBox.Text = "";
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            //Adds each  given items into the listbox. 
            HOFlistBox.Items.Add("KOBE BRYANT [PLAYER]R.I.P.!");
            HOFlistBox.Items.Add("RICK ADELMAN[Coach]");
            HOFlistBox.Items.Add("CHRIS BOSH [Player]");
            HOFlistBox.Items.Add("MICHAEL COOPER [Player]");
            HOFlistBox.Items.Add("TIM HARDAWAY [Player]");
            HOFlistBox.Items.Add("MARQUES JOHNSON [Player]");
            HOFlistBox.Items.Add("PAUL PIERCE [Player]");
            HOFlistBox.Items.Add("BILL RUSSELL [Coach]");
            HOFlistBox.Items.Add("BEN WALLACE [Player]");
            HOFlistBox.Items.Add("CHRIS WEBBER [Player]");
            HOFlistBox.Items.Add("JAY WRIGHT [Coach]");
            HOFlistBox.Items.Add("LETA ANDREWS [Coach]");
            HOFlistBox.Items.Add("YOLANDA GRIFFITH [Player]");
            HOFlistBox.Items.Add("LAUREN JACKSON [Player]");
            HOFlistBox.Items.Add("MARIANNE STANLEY [Coach]");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int count = 1; count <= 3; count++)//Repeats the block of codes.
            {
                MessageBox.Show("CONGRATS! You have won the NBA Finals!");
                //This message is to be displayed as long as statement is true.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This declared variable counts the loop iterations.
            int COUNT = 1;

            //Display the question two times in a message box. 
            while (COUNT <= 2)
            {
                //Displays the message box. 
                MessageBox.Show("Are you Having fun?");

                //Increment count.
                COUNT++;
            }
        }

        private void YEScheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (YEScheckBox.Checked)//this is to run if condition is true.
            {
                MessageBox.Show("Thank you! Im Glad you are Having fun!");
                //message is displayed if statement is true.
            }
        }
        private int Sum( int num1, int num2)//declares which numbers are to be added.
        {
            return num1 + num2;//ends the function, or stops executing.
        }

        private void CombineButton_Click(object sender, EventArgs e)
        {       //variables.
            int yourAge, NbaPlayersAge, CombinedAge;

            if (int.TryParse(YOURtextBox.Text, out yourAge))//converts the string into a double representation.
            {
                if (int.TryParse(NBAtextBox.Text, out NbaPlayersAge))//converts the string into a double representation.
                {
                    CombinedAge = Sum(yourAge, NbaPlayersAge);//adds the numbers within the given list.

                    COMBINEDtextBox.Text = CombinedAge.ToString();
                    //converts the given object to the given string.
                }
                else//An alternative incase the previous statement is false.
                {
                    MessageBox.Show("Enter an integer for your age.");//This message displays if the given statement is true.
                }
            }
        }
        private double FeetToCentimeters(double feet)
        {
            return feet * 30.48;//ends the function, or stops executing.
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //variables
            double feet, centimeters;

            if (double.TryParse(FEETtextBox.Text, out feet))//converts the string into a double representation.
            {
                centimeters = FeetToCentimeters(feet);//converts the 

                CENTIMETERStextBox.Text = centimeters.ToString("n1");
                //converts the given object to the given string, displaying the outcome in numbers.
            }
            else//An alternative if previous condition is false. 
            {
                MessageBox.Show("Enter a Valid number");//Displays the given message when conditions are true.
            }
        }

        private void NOcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NOcheckBox.Checked)//This is to prove if to prove if statement is true.
            {
                MessageBox.Show("I will do better Next Time!");//Displayes the given message when conditions are true.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MOREthirdpage openform = new MOREthirdpage();//Declares which form is to open.
            openform.Show();//opens the new form.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Clears everything within each textbox.
            YOURtextBox.Text = "";
            NBAtextBox.Text = "";
            COMBINEDtextBox.Text = "";       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Clears everything within each textbox.
            FEETtextBox.Text = ""; 
            CENTIMETERStextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
