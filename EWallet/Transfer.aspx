<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Transfer.aspx.cs" Inherits="Transfer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table>
        <tr>
            <td>
                Type:
            </td>
            <td><asp:RadioButtonList OnSelectedIndexChanged="RBtnChange" RepeatDirection="Horizontal" ID="RbtnType" runat="server" >
                <asp:ListItem Selected="True" Text ="Via Phone" Value="1" />
                <asp:ListItem Text ="Via Email" Value="2" />
                </asp:RadioButtonList>                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lbltype" Text="Phone Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtphonemail" runat="server"></asp:TextBox>
            </td>
            <tr>
            <td>
                <asp:Label runat="server" ID="lblbal" Text="Balance"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtbal" runat="server"></asp:TextBox>
            </td>
        </tr>
        </tr>
    </table>
    <asp:Button ID="BtnSend" runat="server" Text="Send" OnClick="BtbSend_Click" />   <asp:Label ID="lblMes" runat="server"  ForeColor="Red" />
</asp:Content>

