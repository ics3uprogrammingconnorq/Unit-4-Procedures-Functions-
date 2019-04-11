/*
 * Created by: Connor Quinlan
 * Created on: 10-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Rounding Program
 * This program rounds a number to however many decimals the user wants.
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

namespace PassByReferenceConnorQ
{
    public partial class frmPassByReference : Form
    {

        double round;
        int decimals;

        public frmPassByReference()
        {
            InitializeComponent();
        }

        public void Round(ref double round, int decimals)
        {
            round = (10 ^ decimals) * round;
            round += 0.5;
            round = Math.Truncate(round);
            round = round / (10 ^ decimals);
            MessageBox.Show("The rounded number is: " + round, "Round Program");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            round = double.Parse(txtInput.Text);
            decimals = Convert.ToInt32(nudInput.Value);

            Round(ref round, decimals);
        }
    }
}
