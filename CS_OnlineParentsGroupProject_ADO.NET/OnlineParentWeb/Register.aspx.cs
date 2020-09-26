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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Parent pt = new Parent
                {
                    parentName = txtUsername.Text
                };
                ParentBusinessLayer pbl = new ParentBusinessLayer();
                int count = pbl.CheckUserRegistration(pt);
                if (count > 0)
                {
                    lblCheck.Text = "Username Already exists";
                }
                else
                {
                    Parent prt = new Parent
                    {
                        parentName = txtUsername.Text,
                        password = txtPwd.Text
                    };
                    pbl.RegisterUser(prt);
                    lblSuccess.Text = "Registration is Successfully done!! You can now post your messages!";
                }
            }
            catch (Exception ex)
            {
                lbl.Text = ex.Message;
            }
        }
    }
}