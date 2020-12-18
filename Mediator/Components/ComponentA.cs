using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	/// <summary>
	/// Компонент А.
	/// </summary>
	public class ComponentA : BaseComponent
	{
		/// <summary>
		/// Действие компонета А типа 1.
		/// </summary>
		public void Act1()
		{
			Console.WriteLine("Компонент A выполяет действие 1.");
			Mediator.Notify(this, 1);
		}

		/// <summary>
		/// Действие компонета А типа 2.
		/// </summary>
		public void Act2()
		{
			Console.WriteLine("Компонент A выполяет действие 2.");
			Mediator.Notify(this, 2);
		}
	}
}
