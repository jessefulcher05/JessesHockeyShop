<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="JessesHockeyShop.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Jesse's Hockey Shop<br />
        123 Main Street <br />
        Missoula, MT 59801<br />
        <abbr title="Phone">P:</abbr>
        406.555.1234
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:jesseshockeyshop@gmail.com">JessesHockeyShop@gmail.com</a><br />
    </address>
</asp:Content>
