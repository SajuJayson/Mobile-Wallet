<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DepositForm.aspx.cs" Inherits="DepositForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <h1>Enter Credit Card Details:</h1><br/>
    <table>
        <tr>
           <td>
             <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
           </td>
           <td>
                <asp:TextBox ID="TxtBoxName" runat="server"></asp:TextBox><br/>
           </td>
        </tr>


        <tr>
           <td>
             <asp:Label ID="Label2" runat="server" Text="Credit Card Number"></asp:Label>
           </td>
           <td>
                <asp:TextBox ID="TxtBoxCcNo" runat="server"></asp:TextBox><br/>
           </td>
        </tr>


        
        <tr>
           <td>
             <asp:Label ID="Label3" runat="server" Text="Expiry Date"></asp:Label>
           </td>
           <td>
                <asp:TextBox ID="TxtBoxExDate" runat="server"></asp:TextBox>
           </td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/image/Calimages.jpg" OnClick="ImageButton1_Click" Width="49px" />
                <asp:Calendar ID="Calendar1" runat="server" Height="16px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            </td>
        </tr>

         <tr>
           <td>
              <asp:Label ID="Label4" runat="server" Text="CVV"></asp:Label>
           </td>
           <td>
                <asp:TextBox ID="TxtBoxCCV" runat="server"></asp:TextBox><br/>
           </td>
            
        </tr>


        <tr>
           <td>
              <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
           </td>
           <td>
                 <asp:TextBox ID="TxtBoxAmount" runat="server"></asp:TextBox>
           </td>
            
        </tr>


        <tr>
            <asp:Label ID="LabelStatus" runat="server"></asp:Label>
        </tr>
         </table><br/>
        
           <asp:Button ID="BtnNext" class="button" runat="server" Text="Next" Height="32px" OnClick="BtnConfirmDeposit_Click" Width="83px" />
        


        
           <asp:Button ID="BtnBack" CssClass="button" runat="server" Height="30px" OnClick="BtnBack_Click" Text="Back" Width="74px" />
       

        







   





   <%--  <h1>Enter Credit Card Details:</h1><br/>
    <asp:Label ID="Label11" runat="server" Text="Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxName1" runat="server"></asp:TextBox><br/>

     <asp:Label ID="Label21" runat="server" Text="Credit Card Number"></asp:Label>
    <asp:TextBox ID="TxtBoxCcNo1" runat="server"></asp:TextBox><br/>

     <asp:Label ID="Label31" runat="server" Text="Expiry Date"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxExDate1" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton11" runat="server" Height="22px" ImageUrl="~/image/Calimages.jpg" OnClick="ImageButton1_Click" Width="49px" />
    <asp:Calendar ID="Calendar11" runat="server" Height="16px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
    <br/>
     <asp:Label ID="Label41" runat="server" Text="CVV"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxCCV1" runat="server"></asp:TextBox><br/>

     <asp:Label ID="Label51" runat="server" Text="Amount"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtBoxAmount1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LabelStatus1" runat="server"></asp:Label>
    <br />
    <br/>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="BtnNext1" class="button" runat="server" Text="Next" Height="32px" OnClick="BtnConfirmDeposit_Click" Width="83px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnBack1" CssClass="button" runat="server" Height="30px" OnClick="BtnBack_Click" Text="Back" Width="74px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />  --%>
</asp:Content>


