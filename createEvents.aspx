﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createEvents.aspx.cs" Inherits="Event_Managment.createEvents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">Title Event : </asp:Label>
    <asp:TextBox ID="title" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Title required" ForeColor="Red" ControlToValidate="title"></asp:RequiredFieldValidator><br />
    <asp:Label runat="server">Start Date : </asp:Label>
    <asp:TextBox ID="sdate" runat="server" TextMode="Date"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Start Date required" ForeColor="Red" ControlToValidate="sdate"></asp:RequiredFieldValidator><br />
    <asp:Label runat="server">Start Time : </asp:Label>
    <asp:TextBox ID="stime" runat="server" ></asp:TextBox><br />
    <asp:Label runat="server">Duration : </asp:Label>
    <asp:TextBox ID="duration" runat="server" ></asp:TextBox><br />
    <asp:Label runat="server" Text="Description : "></asp:Label>
    <asp:TextBox ID="description" runat="server" TextMode="MultiLine" ></asp:TextBox><br />
    <asp:Label runat="server">Location : </asp:Label>
    <asp:TextBox ID="location" runat="server" ></asp:TextBox><br />
    <asp:Label runat="server">Author : </asp:Label>
    <asp:TextBox ID="author" runat="server" ></asp:TextBox><br />
    <asp:Button ID="SubBtn" runat="server" Text="Submit" OnClick="SubBtn_Click"></asp:Button >
</asp:Content>
