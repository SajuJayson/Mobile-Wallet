<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    &nbsp;<div class="jumbotron">
        <h1>EWALLET</h1>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>

    &nbsp;<div class="jumbotron">
        <%--<h1>ASP.NET</h1>--%>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <p><a href="Transfer.aspx" class="btn btn-primary btn-lg">Transfer &raquo;</a>&nbsp; </p>
        <p>&nbsp;</p>
          <p><a href="DepositForm.aspx" class="btn btn-primary btn-lg">Deposit &raquo;</a></p>
        <p>&nbsp;</p>
          <p><a href="WithdrawForm.aspx" class="btn btn-primary btn-lg">Withdraw &raquo;</a></p>
    </div>

</asp:Content>
