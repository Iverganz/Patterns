using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	/// <summary>
	/// Компонент B.
	/// </summary>
	public class ComponentB : BaseComponent
	{
		/// <summary>
		/// Действие компонета B типа 3.
		/// </summary>
		public void Act3()
		{
			Console.WriteLine("Компонент B выполяет действие 3.");
			Mediator.Notify(this, 3);
		}

		/// <summary>
		/// Действие компонета B типа 4.
		/// </summary>
		public void Act4()
		{
			Console.WriteLine("Компонент B выполяет действие 4.");
			Mediator.Notify(this, 4);
		}
	}
}
