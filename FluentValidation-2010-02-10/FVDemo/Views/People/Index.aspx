<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<FVDemo.Models.Person>>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>People</h2>

	<p>
		<%= Html.ActionLink("Add New", "Create") %>
	</p>
	
	<ul>
		<% foreach (var person in Model) { %>
		<li>
			<%= Html.ActionLink(person.Forename + " " + person.Surname, "Edit", new{ id = person.Id }) %>
		</li>
		<% } %>
	</ul>

</asp:Content>
