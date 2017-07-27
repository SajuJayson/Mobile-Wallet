<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


    <h1>REPORT</h1>
    <asp:Label ID="Label1" runat="server" Text="Admin" Font-Bold ></asp:Label>
    <br />
    <asp:GridView ID="ReportGridView" runat="server"></asp:GridView>
 
    <br />
&nbsp;&nbsp;&nbsp;
 
    <asp:Button ID="BtnReportBack" runat="server" Text="Back" OnClick="BtnReportBack_Click" />




</asp:Content>

