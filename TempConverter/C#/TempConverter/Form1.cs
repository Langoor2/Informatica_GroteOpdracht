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
        double VarTmpC;
        double VarTmpF;
        double VarTmpK;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = TempC.Text;
            if (double.TryParse(input, out VarTmpC))
            {
                VarTmpF = (9 * VarTmpC / 5) + 32;
                VarTmpK = VarTmpC + 273.15;
                TempK.Text = VarTmpK + "";
                TempF.Text = VarTmpF + "";
            }
            else
            {
                TempK.Text = "ERROR";
                TempF.Text = TempK.Text;              
            }
        }

        private void TempF_TextChanged(object sender, EventArgs e)
        {

        }

        private void TempK_TextChanged(object sender, EventArgs e)
        {

        }

        private void TempC_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
