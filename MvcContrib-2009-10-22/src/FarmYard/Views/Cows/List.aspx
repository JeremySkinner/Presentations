<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Cow>>" %>
<%@ Import Namespace="FarmYard.Models"%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Showing All Cows
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>All Cows</h2>

	<table>
		<thead>
			<tr>
				<th>Id</th>
				<th>Name</th>
				<th>Date of Birth</th>
				<th>Number of Calves</th>
			</tr>
		</thead>
		<tbody>
			<% foreach (var cow in Model) { %>
				<tr>
					<td>
						<%= cow.Id %>
					</td>
					<td>
						<%= Html.Encode(cow.Name) %>
					</td>
					<td>
						<%= Html.Encode(cow.DateOfBirth.ToString("d")) %>
					</td>
					<td>
						<%= cow.NumberOfCalves %>
					</td>
				</tr>
			<% } %>
		</tbody>
	</table>

















	<%--<%= Html.Grid(Model).Columns(column => {
			column.For(x => x.Id);
			column.For(x => x.Name);
			column.For(x => x.DateOfBirth).Format("{0:d}");
			column.For(x => x.NumberOfCalves);                                                		
	}) %>

--%>

















<%--	<script type="text/javascript">
		$('.grid').dataTable();
	</script>
--%>
</asp:Content>
