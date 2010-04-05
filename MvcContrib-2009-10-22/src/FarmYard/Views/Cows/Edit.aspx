<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Cow>" %>
<%@ Import Namespace="FarmYard.Models"%>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit Cow <%= Html.Encode(Model.Name) %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editing Cow</h2>
    
	<% using (Html.BeginForm()) { %>
		Name: <%= Html.TextBox("Name") %>
		<br />
		Date of Birth: <%= Html.TextBox("DateOfBirth") %>
		<br />
		Number of Calves: <%= Html.TextBox("NumberOfCalves") %>
		<br />
		<input type="submit" value="Save" />
	<%} %>
</asp:Content>
