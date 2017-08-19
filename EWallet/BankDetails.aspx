<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BankDetails.aspx.cs" Inherits="BankDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Bank Details</h1>
    <table>
         <tr>
             <td>
             <asp:Label ID="Label1" runat="server" Text="Bank Name"></asp:Label>
             </td>
             <td>
             <asp:TextBox ID="TextBoxBankName" runat="server"></asp:TextBox>
              </td>
        </tr>
        <tr>
             <td>
              <asp:Label ID="Label2" runat="server" Text="Account No"></asp:Label>
             </td>
             <td>
             <asp:TextBox ID="TextBoxAccountNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
              <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
                </td>
            <td>
                &nbsp;<asp:TextBox ID="TextBoxFName" runat="server"></asp:TextBox>
                </td>
       </tr>
     <tr>
        <td>
        <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
         </td>
        <td>
            &nbsp;<asp:TextBox ID="TextBoxLName" runat="server"></asp:TextBox>
         </td>
     </tr>
    <tr>
        <td>
        <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
            </td>
        <td>
      
        <asp:TextBox ID="TextBoxAmount" runat="server"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>
        <asp:Label ID="LabelStatus" runat="server"></asp:Label>
            </td>
    </tr>

        </table>
    <p>
<<<<<<< HEAD
        <asp:Button class="button" ID="BtnNextWithdraw" runat="server" Text="Next" OnClick="BtnNextWithdraw_Click" Width="72px" />
    &nbsp;&nbsp;
        <asp:Button class="button" ID="BtnBackWithdraw" runat="server" OnClick="BtnBackWithdraw_Click" Text="Back" Width="81px" />
=======
        <asp:Button ID="BtnNextWithdraw"  class="button"  runat="server" Text="Next" OnClick="BtnNextWithdraw_Click" Width="72px" />
    &nbsp;&nbsp;
        <asp:Button ID="BtnBackWithdraw" CssClass="button" runat="server" OnClick="BtnBackWithdraw_Click" Text="Back" Width="81px" />
>>>>>>> 26cafbf7493404765719a59d1660f75c3a1100b5
    </p>
</asp:Content>

