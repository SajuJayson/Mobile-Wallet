<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Transfer.aspx.cs" Inherits="Transfer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <br />
    <br />
    <asp:RadioButton ID="RbtnMobileNo" runat="server" Text="Mobile Number" />
    <asp:TextBox ID="TextBox1" runat="server" Width="166px"></asp:TextBox>
    <br/>
    <asp:RadioButton ID="RBtnEmailId" runat="server" Text="Email-ID" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Width="166px"></asp:TextBox>
    <br/>
    <asp:Label ID="LAmount" runat="server" Text="Amount"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Width="166px"></asp:TextBox>
    <br/>
    <asp:Button ID="BtnSend" runat="server" Text="Send" OnClick="BtbSend_Click" />
</asp:Content>

