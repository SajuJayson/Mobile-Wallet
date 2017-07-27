<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    lo&nbsp;<div class="jumbotron">
        <h1>EWALLET</h1>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>

    &nbsp;<div class="jumbotron">
        <%--<h1>ASP.NET</h1>--%>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <p>
            <asp:Button ID="BtnTransfer" runat="server" Text="Transfer " OnClick="BtnTransfer_Click" /></p>
        <p>&nbsp;</p>
          <p><asp:Button ID="BtnDeposit" runat="server" Text="Deposit " OnClick="BtnDeposit_Click" /></p>
        <p>&nbsp;</p>
          <p><asp:Button ID="BtnWithdraw" runat="server" Text="Withdraw" OnClick="BtnWithdraw_Click" /></p>
        <p>&nbsp;</p>
        <p><asp:Button ID="BtnReport" runat="server" Text="Report" OnClick="BtnReport_Click" Width="132px" /></p>
    </div>

</asp:Content>
