using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccumulateTestScoreData
{
    public partial class Form1 : Form
    {
        List<string> accumulatedTestScores = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            accumulatedTestScores.Add(txtInScore.ToString());
        }

        private void btnDsiplayAccess_Click(object sender, EventArgs e)
        {
            for(int i = 0; i = accumulatedTestScore.Count(); i --)
            {
                
            }
        }
    }
}
