<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    lo&nbsp;<div class="jumbotron">
        <h1>EWALLET</h1>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <%--<p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>--%>
    </div>
    
    &nbsp;<div class="jumbotron">
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
        <%--<h1>ASP.NET</h1>--%>
        <%--<p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>--%>
        <p>
            <asp:Button ID="BtnTransfer" runat="server" Text="Transfer " OnClick="BtnTransfer_Click" /></p>
        <p>&nbsp;</p>
          <p><asp:Button ID="BtnDeposit" runat="server" Text="Deposit " OnClick="BtnDeposit_Click" /></p>
        <p>&nbsp;</p>
          <p><asp:Button ID="BtnWithdraw" runat="server" Text="Withdraw" OnClick="BtnWithdraw_Click" /></p>
        <p>&nbsp;</p>
        <p><asp:Button ID="BtnReport" runat="server" Text="Report" OnClick="BtnReport_Click" Width="126px" /></p>
=======
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
<<<<<<< HEAD
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
        <table><tr>
            <td style="width:200px"><asp:Button ID="BtnTransfer"   Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTUEtzlG6W8ZmpdLnC34D5K1c4bq-1oSuWz8nrWka-O6MODWsd5Mw'); background-size:cover; cursor:hand;" Width="200px" Height="200px" runat="server" Text="Transfer " OnClick="BtnTransfer_Click" /></td>
            <td style="width:200px"><asp:Button ID="BtnDeposit" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('data:image/jpeg;base64,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'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="Deposit " OnClick="BtnDeposit_Click" /></td>
            <td style="width:200px"><asp:Button ID="BtnWithdraw" Font-Bold="True" Font-Size="XX-Large" style=" font-size:larger; background-image:url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSXev9V5uTb6D6dFaD69yYK9wAxvUmxz5toHmuSaIrFuCJqRH_ELg'); background-size:cover; cursor:hand;" Width="200px" Height="200px"  runat="server" Text="Withdraw" OnClick="BtnWithdraw_Click" /></td>
               </tr></table>
            
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
    </div>

</asp:Content>
