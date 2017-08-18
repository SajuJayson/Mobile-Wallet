<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AccountInfo.aspx.cs" Inherits="AccountInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <center><div>
    <h1>User Details</h1>
    <table>
        <tr><td>Customer ID</td><td> <asp:Label ID="LabelCustomerId" runat="server" Text="Customer Id"></asp:Label></td></tr>
        <tr><td>First Name</td><td><asp:Label ID="LabelFirstName" runat="server" Text="First NAme"></asp:Label></td></tr>
        <tr><td>Last Name</td><td><asp:Label ID="LabelLastName" runat="server" Text="Last name"></asp:Label></td></tr>
        <tr><td>Email</td><td><asp:Label ID="LabelEmail" runat="server" Text="Email"></asp:Label></td></tr>
        <tr><td>Account No</td><td><asp:Label ID="LabelAccountNo" runat="server" Text="Account No"></asp:Label></td></tr>
        <tr><td>Phone No</td><td><asp:Label ID="LabelPhoneNo" runat="server" Text="Phone No"></asp:Label></td></tr>
        <tr><td>Balance</td><td><asp:Label ID="LabelRollID" runat="server" Text="Roll ID"></asp:Label></td></tr>
    </table>
    <br />
        <asp:Label ID="LabelOutput" runat="server" ForeColor="Red" Text=""></asp:Label>
        <br />
    <asp:Button ID="BtnTransactionHistory" Class="button" runat="server" Text="Transaction Report" OnClick="BtnTransactionHistory_Click" />
    <br /><br /><br />
    <asp:Label ID="Label1" runat="server" Text="Enter a Customer Id"></asp:Label>
    <asp:TextBox ID="TextBoxCId" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" Class="button" runat="server" Text="Observe a Customer" OnClick="Button1_Click1" />
        </div></center>
</asp:Content>

