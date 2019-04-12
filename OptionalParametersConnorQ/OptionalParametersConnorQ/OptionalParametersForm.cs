/*
 * Created by: Connor Quinlan
 * Created on: 12-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Address Program
 * This program gets information from the user and displays it in a message box.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParametersConnorQ
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                // display missing info
                MessageBox.Show("You didn't input an adress.", "Invalid");
            }
            else
            {
                if (txtCity.Text == "")
                {
                    // display missing info
                    MessageBox.Show("You didn't input a city.", "Invalid");
                }
                else
                {
                    if (txtProvince.Text == "")
                    {
                        // display missing info
                        MessageBox.Show("You didn't input a province.", "Invalid");
                    }
                    else
                    {
                        if (txtPostalCode.Text == "")
                        {
                            // display missing info
                            MessageBox.Show("You didn't input a postal code.", "Invalid");
                        }
                        else
                        {
                            if (txtAptNumber.Text == "")
                            {
                                // call procedure with 4 arguments
                                PrintInfo(txtAddress.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
                            }
                            else
                            {
                                // call procedure with 5 arguments
                                PrintInfo(txtAptNumber.Text, txtAddress.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
                            }
                        }
                    }
                }
            }
        }

        public void PrintInfo(string one, string two, string three, string four)
        {
            // display info with 4 parameters
            MessageBox.Show(one + ", " + two + ", " + three + ", " + four, "Info");
        }

        public void PrintInfo(string one, string two, string three, string four, string five)
        {
            // display info with 5 parameters
            MessageBox.Show(one + ", " + two + ", " + three + ", " + four + ", " + five, "Info");
        }
    }
}
