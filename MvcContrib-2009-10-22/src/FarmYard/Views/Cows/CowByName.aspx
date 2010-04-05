<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Cow>" %>
<%@ Import Namespace="FarmYard.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Cow by Name
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

	<% if(Model == null) { %>
		<p>Could not find a cow!</p>
	<% } else {%>
		<p>Selected cow: <%= Html.Encode(Model.Name) %></p>
	<% } %>
	
</asp:Content>
