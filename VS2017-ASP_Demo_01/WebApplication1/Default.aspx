<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET User Demo</h1>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox1" runat="server" Height="238px" TextMode="MultiLine" Width="1109px" Wrap="False"></asp:TextBox>
    </div>

    <div class="row">
    </div>

</asp:Content>
