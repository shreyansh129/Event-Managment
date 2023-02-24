<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Event_Managment.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Events</h1>
        <p class="lead">Below are the Events.</p>

    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Upcoming Events </h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default">View Details&raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Passed Events </h2>
            <asp:PlaceHolder runat="server" ID="pastE"></asp:PlaceHolder>
            <%--<table>
                <tr>
                    <td>
                        <asp:GridView ID="greedview1" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="title" HeaderText="Title" />
                                <asp:BoundField DataField="sdate" HeaderText="Start date" />
                                <asp:BoundField DataField="stime" HeaderText="Start time" />
                                <asp:BoundField DataField="duration" HeaderText="Duration" />
                                <asp:BoundField DataField="description" HeaderText="Descriptio" />
                                <asp:BoundField DataField="location" HeaderText="Location" />
                                <asp:BoundField DataField="author" HeaderText="Author" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="edit" runat="server" Text="Edit" />
                                        <asp:Button ID="delete" runat="server" Text="Delete" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>--%>
            <asp:ListView ID="ListView1" runat="server">
                <LayoutTemplate>
                    <table id="Table1" runat="server" class="TableCSS">
                        <tr id="Tr1" runat="server" class="TableHeader">
                            <td id="Td1" runat="server">Title</td>
                            <td id="Td2" runat="server">sdate</td>
                            <td id="Td3" runat="server">stime</td>
                            <td id="Td4" runat="server">duration</td>
                        </tr>
                        <tr id="ItemPlaceholder" runat="server">
                        </tr>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr class="TableData">
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("title")%>'>   
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("sdate")%>'>   
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("stime")%>'> 
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("duration")%>'>   
                            </asp:Label>
                        </td>
                        <td>
                            <asp:Button runat="server" ID="VD" OnClick="Unnamed_Click" Text="View Details&raquo;" ></asp:Button>
                            
                               
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>

        </div>
    </div>
    <asp:Button ID="edit" runat="server" class="btn btn-default" Text="Edit" Visible="false" ></asp:Button>
    <asp:Button ID="delete" class="btn btn-default" runat="server" Text="Delete" Visible="false" ></asp:Button>
                           
                            
</asp:Content>
