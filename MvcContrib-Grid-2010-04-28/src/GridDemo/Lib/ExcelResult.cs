namespace GridDemo.Lib {
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Web.Mvc;
	using MvcContrib.UI.Grid;

	public abstract class ExcelResult<T> : ActionResult where T : class {
		private readonly IEnumerable<T> data;

		protected ExcelResult(IEnumerable<T> data) {
			this.data = data;
		}

		private readonly GridModel<T> gridModel = new GridModel<T>();

		public ExcelResult<T> Columns(Action<ColumnBuilder<T>> action) {
			action(gridModel.Column);
			return this;
		}

		public override void ExecuteResult(ControllerContext context) {
			var viewContext = new ViewContext(
				context, 
				new NullView(), 
				context.Controller.ViewData, 
				context.Controller.TempData, 
				context.HttpContext.Response.Output);

			var grid = new Grid<T>(data, context.HttpContext.Response.Output, viewContext)
				.WithModel(gridModel)
				.RenderUsing(new ExcelGridRenderer<T>());
				
			context.HttpContext.Response.ContentType = "application/ms-excel";
			context.HttpContext.Response.AppendHeader("content-disposition", string.Format("attachment; filename=Spreadsheet.xls"));

			grid.Render();
		}

		private class NullView : IView {
			public void Render(ViewContext viewContext, TextWriter writer) {
			}
		}
	}
}