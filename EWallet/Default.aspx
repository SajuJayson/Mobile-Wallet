<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <%--    &nbsp;<div class="jumbotron">
       <%-- <h1>EWALLET</h1>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
  </div>
    
    &nbsp;--%>
            
        <div class="jumbotron">
        <table><tr>
            <td style="width:200px"><asp:Button ID="BtnTransfer"   Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/transfer.jpg'); background-size:cover; cursor:hand;" Width="200px" Height="200px" runat="server" Text="Transfer " OnClick="BtnTransfer_Click" /></td>
            <td style="width:200px"><asp:Button ID="BtnDeposit" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/deposit.jpg'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="Deposit " OnClick="BtnDeposit_Click" /></td>
            <td style="width:200px"><asp:Button ID="BtnWithdraw" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('image/withdraw.jpg'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="Withdraw" OnClick="BtnWithdraw_Click" /></td>
               </tr></table>
            
    </div>

</asp:Content>
