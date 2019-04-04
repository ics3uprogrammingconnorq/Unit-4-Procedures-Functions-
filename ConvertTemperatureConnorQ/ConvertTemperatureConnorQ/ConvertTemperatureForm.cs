/*
 * Created by: Connor Quinlan
 * Created on: 04-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Temperature Converter
 * This program converts a temperature in celsius to fahrenheit.
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

namespace ConvertTemperatureConnorQ
{
    public partial class frmConvertTemperature : Form
    {

        // declare local variables
        double celsius;
        double fahrenheit;

        public frmConvertTemperature()
        {
            InitializeComponent();
        }

        public void CalculateTemperature()
        {
            // calculate answer
            fahrenheit = celsius * 9 / 5 + 32;
            
            // display output
            lblOutput.Text = "The temperature in fahrenheit is " + fahrenheit;
            lblOutput.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // convert input to double
            celsius = double.Parse(txtInput.Text);

            // call calculate procedure
            this.CalculateTemperature();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
