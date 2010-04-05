<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
		<%= Html.ActionLink("Edit Cow 3", "Edit", "Cows", new{ id=3 }, null) %>
    </p>
    <p>
		<%= Html.ActionLink("Show All Cows", "List", "Cows") %>
    </p>
</asp:Content>
