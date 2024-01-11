using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickMathsLib;

namespace QuickMathsDisp
{
    public partial class DivQuizDisplay : UserControl
    {
        int n = -1;
        Quiz q = new Quiz();
        public DivQuizDisplay()
        {
            InitializeComponent();
        }

        private void DivQuizDisplay_Load(object sender, EventArgs e)
        {

        }

        private void EnterAnsBtn_Click(object sender, EventArgs e)
        {
            if (Anstxtbox.Text == "")
            {
                Anstxtbox.Text = "";
                label1.Text = "PLEASE ENTER VALID ANSWER";
            }
            else if (q.DivQuizCheck(Convert.ToInt32(Anstxtbox.Text)) == 1)
            {
                label1.Text = "C O R R E C T";
                Anstxtbox.Text = "";
                n = -1;
            }
            else
            {
                label1.Text = "W R O N G";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n == -1)
            {
                q.DivQuizGenerate();
                QuesLabel.Text = Convert.ToString(q.a) + " ÷ " + Convert.ToString(q.b) + " = ";
                label1.Text = "";
                n = 1;
            }
            else
            {
                label1.Text = "PLEASE ENTER CORRECT ANSWER";
            }
        }
    }
}
