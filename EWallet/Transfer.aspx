<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Transfer.aspx.cs" Inherits="Transfer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Mobile Number"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Width="166px"></asp:TextBox>
    <br/>
    <asp:Label ID="Label2" runat="server" Text="E-Mail Id"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" Width="166px"></asp:TextBox>
    <br/>
    <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" Width="166px"></asp:TextBox>
    <br/>
    <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" />
</asp:Content>

