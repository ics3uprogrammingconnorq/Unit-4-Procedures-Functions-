/*
 * Created by: Connor Quinlan
 * Created on: 25-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Volume of a Cylinder
 * This program calculates the volume of a cylinder.
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

namespace VolOfCylinderConnorQ
{
    public partial class frmVolOfCylinder : Form
    {
        public frmVolOfCylinder()
        {
            InitializeComponent();
        }

        public double CalculateVolume(double height, double radius)
        {
            // declare local variable
            double value;

            // calculate volume
            value = Math.PI * Math.Pow(radius, 2) * height;

            return value;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double height;
            double radius;
            double volume;

            // convert values to doubles
            height = Convert.ToDouble(txtHeight.Text);
            radius = Convert.ToDouble(txtRadius.Text);

            // call function and return volume
            volume = CalculateVolume(height, radius);

            // round volume
            volume = Math.Round(volume, 2);

            MessageBox.Show("The volume of the cylinder is: " + volume + " units cubed", "Volume");
        }
    }
}
