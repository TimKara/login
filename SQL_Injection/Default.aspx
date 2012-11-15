<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SQL_Injection._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUser" runat="server"></asp:TextBox>
    </p>
    <p>
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPWD" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonSend" runat="server" onclick="ButtonSend_Click" 
            Text="UnSafe Login" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Safe" runat="server" onclick="GetIP_Click" Text="Server IP" />
    </p>
    <p>
        Name:&nbsp;
        <asp:Label ID="LabelName" runat="server" Text="null"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;Password:&nbsp;
        <asp:Label ID="LabelPWD" runat="server" Text="null"></asp:Label>
    </p>
    <p>
        SQL:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelSQL" runat="server" Text="null"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    </asp:Content>
