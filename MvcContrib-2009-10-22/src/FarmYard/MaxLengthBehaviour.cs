using System.ComponentModel.DataAnnotations;
using MvcContrib.FluentHtml.Behaviors;
using MvcContrib.FluentHtml.Elements;

namespace FarmYard
{
	public class MaxLengthBehaviour : IBehavior<TextBox>
	{
		public void Execute(TextBox textBox)
		{
			var helper = new MemberBehaviorHelper<StringLengthAttribute>();
			var attribute = helper.GetAttribute(textBox);

			if(attribute == null)
			{
				return;
			}

			textBox.MaxLength(attribute.MaximumLength);
		}
	}
}