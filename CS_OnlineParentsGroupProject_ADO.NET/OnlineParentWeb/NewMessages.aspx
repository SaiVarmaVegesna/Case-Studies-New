<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewMessages.aspx.cs" Inherits="OnlineParentWeb.NewMessages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    body {
            background-image: url('Images/Pic.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: 100% 100% ;
        }
        .auto-style1 {
            color: #C0C0C0;
        }
        .auto-style2 {
            color: #FFFFFF;
        }
        .auto-style3 {
            color: #666666;
        }
        .auto-style4 {
            font-weight: bold;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1 class="auto-style3">Message</h1>
             <hr />
            
             <span class="auto-style1">Subject</span><br />
            <asp:TextBox ID="txtSub" runat="server"></asp:TextBox>
            <strong>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSub" ErrorMessage="Subject must not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </strong>
            <br />
            <br />
             <span class="auto-style1">Message</span><br />
            <asp:TextBox ID="txtMsg" runat="server"></asp:TextBox>
            <strong>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMsg" ErrorMessage="Message is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
            </strong>
            <br />
            <br />
             <span class="auto-style1">Parent Name</span><br />
            <asp:TextBox ID="txtParent" runat="server"></asp:TextBox>
            <strong>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtParent" ErrorMessage="Parent Name is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
            </strong>
            <br />
            <br />
             <strong>
            <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" CssClass="auto-style4" />
             </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>
            <asp:Label ID="lblMsg" runat="server" CssClass="auto-style2" ></asp:Label>
            &nbsp;</em><asp:Label ID="lbl2" runat="server" ForeColor="Red"></asp:Label>
            </strong>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.html">Back to List</asp:HyperLink>
        </div>
    </form>
</body>
</html>
