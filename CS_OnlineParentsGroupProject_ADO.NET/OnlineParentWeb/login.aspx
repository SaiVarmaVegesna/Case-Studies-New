<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="OnlineParentWeb.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            background-color: #666666;
        }
        .auto-style2 {
            font-size: medium;
            background-color: #666666;
        }
        .auto-style3 {
            color: #6666FF;
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
        .auto-style6 {
            background-color: #666666;
        }
        .auto-style7 {
            color: #FFFFFF;
        }
    
        .auto-style8 {
            font-weight: bold;
        }
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;" border="1">
                <tr>
                    <td colspan="2" class="auto-style1">
                        <p class="auto-style2"><strong><span class="auto-style6">Login User</span></strong></p>
                    </td>
                    
                   
                </tr>
                <tr>
                    <td class="auto-style5">Enter Username</td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    &nbsp;<strong><asp:Label ID="lblCheck" runat="server" ForeColor="Red"></asp:Label>
                        </strong>
                    </td>
                   
                </tr>
                <tr>
                    <td class="auto-style5">Enter Password</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        <strong>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="auto-style8" />
                        </strong>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink><strong><span class="auto-style3">&nbsp; </span><span class="auto-style7">New User Register Here!</span><span class="auto-style3"> 
                        <asp:Label ID="lbl1" runat="server" ForeColor="Red"></asp:Label>
                        </span></strong></td>
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
