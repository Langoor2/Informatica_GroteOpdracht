using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_equation
{
    public partial class Form1 : Form
    {
        Double A; // Creating all variables as double
        Double B;
        Double C;
        Double D;
        Double X1;
        Double X2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBoxA.Text, out A)) // Check if the A value is numeric.
            {
                if (Double.TryParse(textBoxB.Text, out B)) // If A is numeric, then check if B is numeric
                {
                    if (Double.TryParse(textBoxC.Text, out C)) // If B is numeric, then check C. This can be done nicer.
                    { // The checking could be done nicer. But this works
                        D = Math.Pow(B, 2) - 4 * A * C; // Calculate D
                        textBoxD.Text = D + ""; // Parse the Double variable of D to a textbox
                        if (D < 0) // Check if D is less then 0, then give an error
                        {
                            textBoxX1.Text = "Error";
                            textBoxX2.Text = "D<0, Can't solve";
                        }
                        else if (D == 0) // Check if D is 0, then calculate X1
                        {
                            X1 = -B / 2 * A;
                            textBoxX1.Text = X1 + ""; // Parse the double variable to a textbox
                            textBoxX2.Text = "";
                        }
                        else if (D>0) // Check if D is bigger then 0, then calculate X1 and X2
                        {
                            X1 = (-B + Math.Sqrt(D)) / (2 * A);
                            X2 = (-B - Math.Sqrt(D)) / (2 * A);
                            textBoxX1.Text = X1 + ""; // Parse the double variable to a textbox
                            textBoxX2.Text = X2 + ""; // Parse the double variable to a textbox
                        }
                    }
                }
             }
        }
    }
}
