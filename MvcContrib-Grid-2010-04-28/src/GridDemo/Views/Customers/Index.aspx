<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<GridDemo.Models.Customer>>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Grid Demo</h2>

	<table>
		<thead>
			<tr>
				<th>Name</th>
				<th>Date of Birth</th>
				<th>&nbsp;</th>
			</tr>
		</thead>
		<tbody>
			<% foreach(var customer in Model) { %>
				<tr>
					<td><%= Html.Encode(customer.Name) %></td>
					<td><%= "{0:d}", customer.DateOfBirth %></td>
					<td>
						<%= Html.ActionLink("View Details", "Show", new{id = customer.Id }) %>
					</td>
				</tr>
			<% } %>
		</tbody>
	</table>
</asp:Content>
