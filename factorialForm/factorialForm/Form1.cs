using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorialForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(inputLabel.Text); 
            double fact;
            fact = number;
            for (double i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            outputBox.Text = fact.ToString("N0");
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
