using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_Random_Numbers
{
    public partial class frmRandomNumbers : Form
    {
        Random generator = new Random();
        Double randomNumDec;
        int randomNum;
        double Minimum;
        double Maximum;


        public frmRandomNumbers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Minimum = Convert.ToInt32(txtMinimum.Text);
            int Maximum = Convert.ToInt32(txtMaximum.Text);
            randomNumDec = generator.NextDouble();
            randomNum = generator.Next(Minimum, Maximum);
            lblResult.Text = ("Result = " + (randomNum + randomNumDec - 1));
        }

        private void frmRandomNumbers_Load(object sender, EventArgs e)
        {

        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            Minimum = Convert.ToInt32(txtMinimum.Text);
            Maximum = Convert.ToInt32(txtMaximum.Text);
            randomNum = generator.Next((int)Minimum, (int)Maximum);
            lblResult.Text = (" Result = " + randomNum);


        }
    }
}
