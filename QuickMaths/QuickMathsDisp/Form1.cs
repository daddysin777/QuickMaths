using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickMathsDisp
{
    public partial class MainDisp : Form
    {
        public MainDisp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddQuizDisplay addquizdisplay = new AddQuizDisplay();
            //panel2.BringToFront(addquizdisplay);
        }

        private void subQuizDisplay1_Load(object sender, EventArgs e)
        {

        }

        private void AddQuizBtn_Click(object sender, EventArgs e)
        {
            addQuizDisplay1.BringToFront();
        }

        private void SubQuizBtn_Click(object sender, EventArgs e)
        {
            subQuizDisplay1.BringToFront();
        }

        private void MulQuizBtn_Click(object sender, EventArgs e)
        {
            mulQuizDisplay1.BringToFront();
        }

        private void DivQuizBtn_Click(object sender, EventArgs e)
        {
            divQuizDisplay1.BringToFront();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            profileDisplay1.BringToFront();
        }
    }
}
