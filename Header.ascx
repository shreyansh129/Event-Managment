<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="Event_Managment.Header" %>
<ul class="nav navbar-nav">
    <li><a runat="server" href="~/Home">Home</a></li>
    <li><a runat="server" href="~/About">About</a></li>
    <li><a runat="server" href="~/Contact">Contact</a></li>
    <li>
        <asp:LinkButton ID="Li" runat="server" Text="Button" OnClick="Li_Click" CausesValidation="false">Login</asp:LinkButton></li>
    <li>
        <asp:LinkButton ID="Lo" runat="server" Text="Button" OnClick="Lo_Click" Visible="False" CausesValidation="false">Logout</asp:LinkButton></li>
    <li>
        <asp:LinkButton ID="Ri" runat="server" Text="Button" OnClick="Ri_Click" CausesValidation="false">Register</asp:LinkButton></li>
    <li>
        <asp:LinkButton ID="CE" runat="server" Text="Button" OnClick="CE_Click" Visible="false" CausesValidation="false">CreateEvent</asp:LinkButton></li>
</ul>
