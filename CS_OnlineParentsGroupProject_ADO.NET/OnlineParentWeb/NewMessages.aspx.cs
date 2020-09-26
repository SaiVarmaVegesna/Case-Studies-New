using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MessagesBusinessLayer;

namespace OnlineParentWeb
{
    public partial class NewMessages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBusinessLayer mbl = new MessageBusinessLayer();
                mbl.PostMessage(txtParent.Text, txtSub.Text, txtMsg.Text);
                lblMsg.Text = "Your message is Recorded";
            }
            catch (Exception ex)
            {
                lbl2.Text = ex.Message;
            }
        }
    }
}