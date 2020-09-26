using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using OnlineParentEntities;
using OnlineParentBusinessLayer;

namespace OnlineParentWeb
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Parent pt = new Parent
                {
                    parentName = txtUsername.Text,
                    password = txtPwd.Text
                };
                ParentBusinessLayer pbl = new ParentBusinessLayer();
                int count = pbl.Checklogin(pt);
                if (count > 0)
                {
                    Response.Redirect("~/NewMessages.aspx");
                }
                else
                {
                    lblCheck.Text = "Username does not exist!";

                }
            }
            catch (Exception ex)
            {
                lbl1.Text = ex.Message;
            }
        }
    }
}