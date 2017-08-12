<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AcknowledgementForm.aspx.cs" Inherits="AcknowledgementForm" %>

<asp:Content ID="L" ContentPlaceHolderID="MainContent" Runat="Server">
    <center>
    <table style="width:100%;" > <tr><td style="height: 40px"></td></tr>
        <tr><td>
    <asp:Label ID="LabelAcknowledgement" runat="server" Text="Acknowledgement"></asp:Label></td></tr>
    <tr><td></td></tr><tr><td>
<asp:Button class="button" ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />
        </td></tr>
   </table>
        </center>
</asp:Content>

