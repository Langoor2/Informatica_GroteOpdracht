using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class Form1 : Form
    {
        double VarTmpC; // Creating variables
        double VarTmpF;
        double VarTmpK;

        public Form1()
        {
            InitializeComponent();

        }
        private void TempC_TextChanged(object sender, EventArgs e)
        {
            String input = TempC.Text;
            if (double.TryParse(input, out VarTmpC)) // Checks if the input is a number
            {
                VarTmpF = (9 * VarTmpC / 5) + 32; // Formula for ºC -> ºF
                VarTmpK = VarTmpC + 273.15; // Formula for ºC -> K
                TempK.Text = VarTmpK + ""; // Converts double variable to a textbox
                TempF.Text = VarTmpF + ""; // There is a nicer way to do this, but this was easier
            }
            else // Triggers an error when the user enters a non-number value
            {
                TempK.Text = "ERROR";
                TempF.Text = TempK.Text;
            }
        }
    }
}
