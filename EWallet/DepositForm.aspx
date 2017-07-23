<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DepositForm.aspx.cs" Inherits="DepositForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Enter Credit Card Details:</h1><br/>
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxName" runat="server"></asp:TextBox><br/>

     <asp:Label ID="Label2" runat="server" Text="Credit Card Number"></asp:Label>
    <asp:TextBox ID="TxtBoxCcNo" runat="server"></asp:TextBox><br/>

     <asp:Label ID="Label3" runat="server" Text="Expiry Date"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxExDate" runat="server"></asp:TextBox><br/>

     <asp:Label ID="Label4" runat="server" Text="CVV"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxCCV" runat="server"></asp:TextBox><br/>

     <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxAmount" runat="server"></asp:TextBox><br/>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnConfirmDeposit" runat="server" Text="Confirm" Height="32px" OnClick="BtnConfirmDeposit_Click" Width="83px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>


