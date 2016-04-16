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
        Double A;
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
            if (Double.TryParse(textBoxA.Text, out A))
            {
                if (Double.TryParse(textBoxB.Text, out B))
                {
                    if (Double.TryParse(textBoxC.Text, out C))
                    {
                        D = Math.Pow(B, 2) - 4 * A * C;
                        textBoxD.Text = D + "";
                        if (D < 0)
                        {
                            textBoxX1.Text = "Error";
                            textBoxX2.Text = "D<0, Can't solve";
                        }
                        else if (D == 0)
                        {
                            X1 = -B / 2 * A;
                            textBoxX1.Text = X1 + "";
                            textBoxX2.Text = "";
                        }
                        else if (D>0)
                        {
                            X1 = (-B + Math.Sqrt(D)) / (2 * A);
                            X2 = (-B - Math.Sqrt(D)) / (2 * A);
                            textBoxX1.Text = X1 + "";
                            textBoxX2.Text = X2 + "";                       
                        }
                    }
                }
             }
        }
    }
}
