<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FVDemo.Models.Person>" %>
<%= Html.ValidationSummary() %>

<%= Html.EditorForModel() %>