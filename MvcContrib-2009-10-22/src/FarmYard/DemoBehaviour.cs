using System;
using MvcContrib.FluentHtml.Behaviors;
using MvcContrib.FluentHtml.Elements;

namespace FarmYard
{
	public class DemoBehaviour : IBehavior<TextBox>
	{
		public void Execute(TextBox element)
		{
			element.Class("demo");
		}
	}
}