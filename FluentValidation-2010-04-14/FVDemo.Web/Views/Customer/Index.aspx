<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Customer>" MasterPageFile="~/Views/Shared/Site.Master" %>
<%@ Import Namespace="FVDemo" %>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
	<% using(Html.BeginForm()) { %>
		<%= Html.EditorForModel() %>
		<input type="submit" value="Save" />
	<% } %>
</asp:Content>
