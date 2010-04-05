<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<FVDemo.Models.Person>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

	<%= Html.ValidationSummary() %>
	
	<% using(Html.BeginForm()) { %>
		<%= Html.EditorForModel() %>
		
		<p>
			<input type="submit" value="Save" />
		</p>
	<% } %>

</asp:Content>
