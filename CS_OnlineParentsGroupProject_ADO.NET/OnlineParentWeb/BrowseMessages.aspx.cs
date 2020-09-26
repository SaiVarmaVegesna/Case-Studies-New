using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MessagesBusinessLayer;
using OnlineParentEntities;

namespace OnlineParentWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBusinessLayer mbl = new MessageBusinessLayer();
                mbl.GetMessagesBySubject(DropDownList1.SelectedValue);

                string subject = DropDownList1.SelectedValue;
                Session.Add("subject", subject);

                Response.Redirect("~/DisplayMessages.aspx?subject=" + DropDownList1.SelectedValue);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        
    }
}