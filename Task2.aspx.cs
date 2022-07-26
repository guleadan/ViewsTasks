using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateTask2
{
    
    public partial class Task2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            {
                string f = fName.Value;
                string s= sName.Value;
                //ViewState["fname"] = f;
                //ViewState["sname"] = s;
                //string hfirst = hiddenfName.Value;
                //string hsecond = hiddensName.Value;
            }

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            ViewState["fname"] = fName.Value;
            ViewState["sname"] = sName.Value;
            fName.Value ="";
            sName.Value = "";
           
        }
        public void ViewState_Click(object sender, EventArgs e)
        {
         
            string alpha = Convert.ToString(ViewState["fname"]);
            string bravo = Convert.ToString(ViewState["sname"]);
            fName.Value = alpha;
            sName.Value = bravo;
            ViewState["fname"] = alpha;
            ViewState["sname"] = bravo;

        }
        public void HiddenField_Click(object sender, EventArgs e)
        {

            string fname = hiddenfName.Value;
            string sname = hiddensName.Value;
            fName.Value = fname;
            sName.Value = sname;

        }
    }
}