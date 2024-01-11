using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickMathsLib;
using System.Threading;

namespace QuickMathsDisp
{
    public partial class AddQuizDisplay : UserControl
    {

        int n = -1;
        Quiz q = new Quiz();

        public AddQuizDisplay()
        {
            InitializeComponent();
        }

        private void AddQuizDisplay_Load(object sender, EventArgs e)
        {
            
        }

        private void EnterAnsBtn_Click(object sender, EventArgs e)
        {
            if(Anstxtbox.Text == "")
            {
                Anstxtbox.Text = "";
                label1.Text = "PLEASE ENTER VALID ANSWER";
            }
            else if (q.AddQuizCheck(Convert.ToInt32(Anstxtbox.Text)) == 1)
            {
                label1.Text = "C O R R E C T \n" +
                              "PRESS NEXT";
                Anstxtbox.Text = "";
                n = -1;
            }
            else
            {
                label1.Text = "W R O N G";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (n == -1)
            {
                q.AddQuizGenerate();
                QuesLabel.Text = Convert.ToString(q.a) + " + " + Convert.ToString(q.b) + " = ";
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
