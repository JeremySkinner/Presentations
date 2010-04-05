using MvcContrib.FluentHtml;

namespace FarmYard
{
	public class MyViewPage<T> : ModelViewPage<T> where T : class
	{
		public MyViewPage()
		{
			behaviors.Add(new DemoBehaviour());
			//behaviors.Add(new MaxLengthBehaviour());
		}
	}
}