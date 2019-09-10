using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace TestApplication
{
    internal class Presenter
    {
        Model myModel;
        Form1 mainForm;
        public Presenter(Form1 f)
        {
            mainForm = f;
            myModel = new Model();
            mainForm.factBtnEv += factHandler;
            mainForm.srtBtnEv += srtHandler;
            mainForm.srcBtnEv += srcHandler;
            mainForm.strSrcBtnEv += strHandler;
            mainForm.seqBtnEv += seqHandler;
        }

        void srtHandler(object sender, EventArgs e)
        {
            mainForm.tBoxOut.Text = myModel.IntSort(mainForm.tBoxIn.Text);
        }

        void srcHandler(object sender, EventArgs e)
        {
            int sw = myModel.Search((int)mainForm.srcNumUd.Value);

            switch (sw)
            {
                case 1:
                    mainForm.srcResLbl.Text = "Item is listed";
                    break;
                case 0:
                    mainForm.srcResLbl.Text = "Array is empty";
                    break;
                case -1:
                    mainForm.srcResLbl.Text = "Item isn't listed";
                    break;
                default:
                    mainForm.srcResLbl.Text = "Stand by";
                    break;
            }

        }

        void factHandler(object sender, EventArgs e)
        {
            mainForm.factLblRes.Text = Convert.ToString(myModel.FactCount((int)mainForm.factNumUd.Value));
        }

        void strHandler(object sender, EventArgs e)
        {
            mainForm.strTboxRes.Text = myModel.StrSearch(mainForm.strTboxSource.Text);
        }

        void seqHandler(object sender, EventArgs e)
        {
            mainForm.seqTboxRes.Text = myModel.Check(mainForm.seqTboxSrc.Text);
        }


    }
}
