namespace GridDemo.Lib {
	using System.Linq;
	using System.Web;
	using MvcContrib.UI.Grid;

	public class DetailsGridRenderer<T> : HtmlTableGridRenderer<T> where T : class {
		public string Title { get; set; }

		protected override void RenderHeaderCellStart(GridColumn<T> column) {
		}

		protected override void RenderHeaderCellEnd() {
		}

		protected override void RenderRowStart(GridRowViewData<T> rowData) {
		}

		protected override void RenderRowEnd() {
		}

		protected override void RenderHeadStart() {
		}

		protected override void RenderHeadEnd() {
		}


		protected override bool RenderHeader() {
			bool shouldRender = (base.DataSource != null && DataSource.Any());

			if (shouldRender && Title != null) {
				RenderText("<thead><tr><th colspan=\"2\">" + HttpUtility.HtmlEncode(Title) + "</th></tr></thead>");
			}
			return shouldRender;
		}

		protected override void RenderStartCell(GridColumn<T> column, GridRowViewData<T> rowData) {
			RenderText("<tr>");
			RenderText("<td>");
			RenderText(column.Name);
			RenderText("</td>");
			RenderText("<td>");
		}

		protected override void RenderEndCell() {
			RenderText("</td></tr>");
		}
	}
}