<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BrowseMessages.aspx.cs" Inherits="OnlineParentWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
       
    .auto-style3 {
        text-align: center;
        color: #C0C0C0;
    }
    .auto-style4 {
        color: #C0C0C0;
    }
       
        .auto-style5 {
            color: #000000;
        }
       
    .auto-style6 {
        font-weight: bold;
    }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="auto-style3"><strong>Browse Your Messages</strong></h2>
    <p class="auto-style2">
        <span class="auto-style4">Select Subject:
        </span>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="subject" DataValueField="subject" AutoPostBack="True" >
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DXCConnectionString %>" SelectCommand="SELECT * FROM [tbl_messages]"></asp:SqlDataSource>
    </p>
    <p class="auto-style2">
        <strong>
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" CssClass="auto-style6" />
        </strong>
        <span class="auto-style5">&nbsp;&nbsp;&nbsp; </span> <strong>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="auto-style4"></asp:Label>
        </strong>
    </p>
</asp:Content>
