<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BankDetails.aspx.cs" Inherits="BankDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Bank Details</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Bank Name"></asp:Label>
        <asp:TextBox ID="TextBoxBankName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Account No"></asp:Label>
        <asp:TextBox ID="TextBoxAccountNo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
    &nbsp;<asp:TextBox ID="TextBoxFName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxLName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxAmount" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LabelStatus" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="BtnNextWithdraw" runat="server" Text="Next" OnClick="BtnNextWithdraw_Click" Width="72px" />
    &nbsp;&nbsp;
        <asp:Button ID="BtnBackWithdraw" runat="server" OnClick="BtnBackWithdraw_Click" Text="Back" Width="81px" />
    </p>
</asp:Content>

