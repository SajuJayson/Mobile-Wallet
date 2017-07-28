<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConfirmationForm.aspx.cs" Inherits="ConfirmationForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br/>
    <br/>
    <table><tr><td>
    <asp:Label ID="Label2" runat="server" Text="Your Current Balance is: "></asp:Label>
    </td><td>
    <asp:Label ID="LabelCurrentBalance" runat="server" Text=""></asp:Label><br/><br/>
    </td></tr><tr><td>
    <asp:Label ID="Label1" runat="server" Text="Amount deducted is: "></asp:Label>
    </td><td>
        <asp:Label ID="LabelAmountDeducted" runat="server" Text=" "></asp:Label><br/><br/>
    </td></tr><tr><td>
        <asp:Label ID="Label3" runat="server" Text="Your updated balance is: "></asp:Label>
        </td><td>
    <asp:Label ID="LabelUpdatedBalance" runat="server" Text=" "></asp:Label><br/><br/>
        </td></tr><tr><td></table>

    <asp:Button ID="BtnConfirm" runat="server" Text="Confirm" OnClick="Button1_Click" />
     <asp:Button ID="BtnBackConfirmForm" runat="server" Text="Back" OnClick="Button1_Click" />
    <br />
    <br />
    <br />
    <br/>


</asp:Content>

