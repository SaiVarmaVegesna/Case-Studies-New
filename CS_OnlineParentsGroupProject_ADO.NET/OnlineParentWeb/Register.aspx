<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="OnlineParentWeb.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
        }
               
        body {
            background-image: url('Images/Pic.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: 100% 100% ;
        }
    
        .auto-style5 {
            color: #C0C0C0;
        }
        .auto-style7 {
            color: #FFFFFF;
        }
    
        .auto-style10 {
            text-align: center;
        }
        .auto-style12 {
            background-color: #666666;
        }
    
        .auto-style13 {
            font-weight: bold;
        }
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;" border="1">
                <tr>
                    <td colspan="2" class="auto-style12" >
                        <p class="auto-style10" ><strong>Register User</span></strong></p>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style5">Enter Username:</td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                        <strong>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="username is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;
                        <asp:Label ID="lblCheck" runat="server" ForeColor="Red"></asp:Label>
                        </strong>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style5">Enter Password:</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" ></asp:TextBox>
                        <strong>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" Display="Dynamic" ErrorMessage="password is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                        </strong>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style5">Confirm Password:</td>
                    <td>
                        <asp:TextBox ID="txtRetype" runat="server"></asp:TextBox>
                        <strong>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtRetype" Display="Dynamic" ErrorMessage="Password must be same" ForeColor="Red"></asp:CompareValidator>
                        </strong>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style1">
                        <strong>
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" style="height: 35px" CssClass="auto-style13" />
                        </strong>
                    </td>
                    <td>
                        <em><strong>
                        <asp:Label ID="lblSuccess" runat="server" CssClass="auto-style7"  ></asp:Label>
                        &nbsp;&nbsp;
                        <asp:Label ID="lbl" runat="server" ForeColor="Red"></asp:Label>
                        </strong></em>
                    </td>
                </tr>
            </table>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.html">Home</asp:HyperLink>
    </form>
</body>
</html>
