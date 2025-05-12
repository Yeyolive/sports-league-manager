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
    public partial class GAMES : Form
    {
        public GAMES()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //When Pressing the Back button, this is supposed to take you back to the MainFrom.
            this.Close();
            MainForm openform = new MainForm();
            openform.Show();
        }

        private void INDcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (INDcheckBox.Checked) //When the checkbox is checked, the following message will be displayed, if the
                //condition is true.
            {
                MessageBox.Show("You Have chosen the Pacers to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void CLEcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CLEcheckBox.Checked)//When the checkbox is checked, the following message will be displayed, if the
                 //condition is true.
            {
                MessageBox.Show("You Have chosen the Cavs to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void WSHcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WSHcheckBox.Checked) //When the checkbox is checked, the following message will be displayed, 
                    //if the condition is true. 
            {
                MessageBox.Show("You Have chosen the Wizards to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void ATLcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ATLcheckBox.Checked)// When the checkbox is checked, the following message will be displayed, if the
                 //condition is true.
            {
                MessageBox.Show("You Have chosen the Hawks to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void NOcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NOcheckBox.Checked) //When the checkbox is checked, the following message will be displayed.
                //if the condition is true.
            {
                MessageBox.Show("You Have chosen the Pelicans to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void MEMcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MEMcheckBox.Checked)// When the checkbox is checked, the following message will be displayed, if the
                 //condition is true.
            {
                MessageBox.Show("You Have chosen the Grizzlies to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void MILcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MILcheckBox.Checked) //When the checkbox is checked, the following message will be displayed.
                //if the condition is true.
            {
                MessageBox.Show("You Have chosen the Bucks to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void SAcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SAcheckBox.Checked)//When the checkbox is checked, the following message will be displayed, if the
                 //condition is true.
            {
                MessageBox.Show("You Have chosen the Spurs to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void UTAHcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UTAHcheckBox.Checked)//When the checkbox is checked, the following message will be displayed.
                //if the condition is true.
            {
                MessageBox.Show("You Have chosen the Jazz to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void GScheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GScheckBox.Checked)//When the checkbox is checked, the following message will be displayed, if the
                 //condition is true.
            {
                MessageBox.Show("You Have chosen the Warriors to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void HOUcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HOUcheckBox.Checked)//When the checkbox is checked, the following message will be displayed.
                //if the condition is true.
            {
                MessageBox.Show("You Have chosen the Rockets to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }

        private void PORcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PORcheckBox.Checked)//When the checkbox is checked, the following message will be displayed, if the
                 //condition is true.
            {
                MessageBox.Show("You Have chosen the Blazers to Win Today!");//This is to display in the messageBox ,
                //the choice you made within the checkbox.
            }
        }
    }
}
