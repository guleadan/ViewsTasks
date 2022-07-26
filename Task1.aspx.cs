using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateTask1
{
    public partial class Task1 : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                {
                    ViewState["txt"] = i;
                }
            }
        }

        public void Btn_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(ViewState["txt"]);
            i += 1;
            txt.Value = Convert.ToString(i);
            ViewState["txt"] = i;
           



        }
    }
}