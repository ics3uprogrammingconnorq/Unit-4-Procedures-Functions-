/*
 * Created by: Connor Quinlan
 * Created on: 15-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Percentage Program
 * This program calculates a percentage based on a given grade by the user.
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

namespace PercentageProgramConnorQ
{
    public partial class frmPercentageProgram : Form
    {
        // declare global variable
        int percentage;

        public frmPercentageProgram()
        {
            InitializeComponent();
        }

        public int CalculatePercentage(string level)
        {
            // switch case for level
            switch (level)
            {
                // convert level to percentage
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }

            // return percentage to display
            return percentage;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // declare local variables
            string level = txtInput.Text;
            int mark;

            // set mark to the return value of CalculatePercentage function
            mark = CalculatePercentage(level);


            // display mark to user
            MessageBox.Show("Your mark is: " + mark + "%", "Grade");
        }
    }
}
