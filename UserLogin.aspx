<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Event_Managment.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3><asp:Label runat="server" ID="Htext" Text="Login Here!!!" ></asp:Label> </h3>
    <h5><asp:Label ID="errorMsg" runat="server" ></asp:Label></h5>
        <asp:Label runat="server" Text="Email: " ></asp:Label>
        <asp:TextBox runat="server" TextMode="Email" ID="mail"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Valid" runat="server" ErrorMessage="PLease enter your Email-ID" ForeColor="Red" ControlToValidate="mail"></asp:RequiredFieldValidator><br />
       <asp:Label runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="Password" runat="server" TextMode="Password" ToolTip="Enter Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Password required" ForeColor="Red" ControlToValidate="Password"></asp:RequiredFieldValidator><br />
       <asp:Button ID="loginBtn" runat="server" Text="Submit" OnClick="Login_btn_click"></asp:Button>
</asp:Content>
