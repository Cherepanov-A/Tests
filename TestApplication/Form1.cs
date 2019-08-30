using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            tBoxOut.Text = Presenter.Sort(tBoxIn.Text);
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            srcResLbl.Text = Presenter.Search((int)srcNumUd.Value);
        }

        private void factBtn_Click(object sender, EventArgs e)
        {
            factLblRes.Text = Presenter.Fact((int)factNumUd.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strTboxRes.Text = Presenter.StrSrch(strTboxSource.Text);
        }

        private void seqBtn_Click(object sender, EventArgs e)
        {
            if (Presenter.Seq(seqTboxSrc.Text))
            {
                seqTboxRes.Text = "Correct sequence";
            }
            else
            {
                seqTboxRes.Text = "Incorrect sequence";
            }
        }
    }
}
