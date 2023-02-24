<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="Event_Managment.UserRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><asp:Label ID="reglab" runat="server">Register Here!!!</asp:Label></h1>
    <h5><asp:Label ID="checkmail" runat="server" ForeColor="Red"></asp:Label></h5>
    <asp:Label ID="label1" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="mail" runat="server" TextMode="Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="Valid" runat="server" ErrorMessage="PLease enter your Email-ID" ForeColor="Red" ControlToValidate="mail"></asp:RequiredFieldValidator><br />
    <asp:Label ID="label2" runat="server" Text="Password: "></asp:Label>
    <asp:TextBox ID="password" runat="server" TextMode="Password" ToolTip="Enter Password"></asp:TextBox> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Password required" ForeColor="Red" ControlToValidate="Password"></asp:RequiredFieldValidator><br />
    <asp:Label ID="label4" runat="server" Text="FullName: "></asp:Label>
    <asp:TextBox ID="fullname" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="FullName required" ForeColor="Red" ControlToValidate="fullname"></asp:RequiredFieldValidator><br />
    <asp:Button ID="regBtn" runat="server" Text="Submit" OnClick="reg_btn_click"></asp:Button>
</asp:Content>
