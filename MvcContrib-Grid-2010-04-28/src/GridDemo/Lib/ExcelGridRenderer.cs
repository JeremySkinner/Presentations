namespace GridDemo.Lib {
	using System;
	using MvcContrib.UI.Grid;

	public class ExcelGridRenderer<T> : GridRenderer<T> where T : class {

		private string name = "Worksheet 1";

		public string Name {
			get { return name; }
			set { name = value; }
		}

		protected override void RenderHeaderCellEnd() {
			RenderText("</Data></Cell>");
			
		}

		protected override void RenderHeaderCellStart(GridColumn<T> column) {
			RenderText("<Cell><Data ss:Type=\"String\">");
		}

		protected override void RenderRowStart(GridRowViewData<T> rowData) {
			RenderText("<Row>");
		}

		protected override void RenderRowEnd() {
			RenderText("</Row>");
		}

		protected override void RenderEndCell() {
			RenderText("</Data></Cell>");
		}

		protected override void RenderStartCell(GridColumn<T> column, GridRowViewData<T> rowViewData) {
			RenderText("<Cell><Data ss:Type=\"String\">");
		}

		protected override void RenderHeadStart() {
			RenderText("<Row>");

		}

		protected override void RenderHeadEnd() {
			RenderText("</Row>");
		}

		protected override void RenderGridStart() {
			RenderText("<?xml version=\"1.0\"?>");
			RenderText(
				"<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\" xmlns:html=\"http://www.w3.org/TR/REC-html40\">");
			RenderText("<Styles>");
			RenderText("<Style ss:ID=\"Default\" ss:Name=\"Normal\">");
			RenderText("<Alignment ss:Vertical=\"Bottom\" />");
			RenderText("<Borders/>");
			RenderText("<Font ss:FontName=\"Verdana\" />");
			RenderText("<Interior/>");
			RenderText("<NumberFormat/>");
			RenderText("<Protection/>");
			RenderText("</Style>");
			RenderText("</Styles>");
			RenderText("<Worksheet ss:Name=\"" + Name + "\">");
			RenderText("<Table>");
		}

		protected override void RenderGridEnd(bool isEmpty) {
			RenderText("</Table>");
			RenderText("</Worksheet>");
			RenderText("</Workbook>");
		}

		protected override void RenderEmpty() {
		}

		protected override void RenderBodyStart() {
			
		}

		protected override void RenderBodyEnd() {
		}
	}
}