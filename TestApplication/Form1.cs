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
            new Presenter(this);
        }
        public event EventHandler factBtnEv;
        public event EventHandler strSrcBtnEv;
        public event EventHandler srcBtnEv;
        public event EventHandler srtBtnEv;
        public event EventHandler seqBtnEv;

        private void sortBtn_Click(object sender, EventArgs e)
        {
            srtBtnEv.Invoke(sender, e);           
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            srcBtnEv.Invoke(sender, e);
        }

        private void factBtn_Click(object sender, EventArgs e)
        {
            factBtnEv.Invoke(sender, e);
        }        

        private void seqBtn_Click(object sender, EventArgs e)
        {
            seqBtnEv.Invoke(sender, e);
        }

        private void strBtn_Click(object sender, EventArgs e)
        {
            strSrcBtnEv.Invoke(sender, e);
        }
    }
}
