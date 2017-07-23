<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConfirmationForm.aspx.cs" Inherits="ConfirmationForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br/>
    <br/>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Confirm Amount</h1><br/>
    <asp:Label ID="Label2" runat="server" Text="Your Current Balance is: "></asp:Label>
    <asp:Label ID="LabelCurrentBalance" runat="server" Text="balance"></asp:Label>
    <br />
    <br/>
    <asp:Label ID="Label1" runat="server" Text="Amount deducted is: "></asp:Label>
    <asp:Label ID="LabelAmountDeducted" runat="server" Text="deduct "></asp:Label>
    <br />
    <br/>
    <asp:Label ID="Label3" runat="server" Text="Your updated balance is: "></asp:Label>
    <asp:Label ID="LabelUpdatedBalance" runat="server" Text="updated balance "></asp:Label>
    <br />
    <br />
    <br/><br/>
    &nbsp;&nbsp;
    <asp:Button ID="BtnConfirm" runat="server" Text="Confirm" OnClick="Button1_Click" />
     <asp:Button ID="BtnBackConfirmForm" runat="server" Text="Back" OnClick="Button1_Click" />
    <br />
    <br />
    <br />
    <br/>


</asp:Content>

