using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	/// <summary>
	/// Медиатор.
	/// </summary>
	public class ComponentMediator : IMediator
	{
		/// <summary>
		/// Компонент A.
		/// </summary>
		private readonly ComponentA _componentA;

		/// <summary>
		/// Компонент B.
		/// </summary>
		private readonly ComponentB _componentB;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="componentA"> Компонент A.</param>
		/// <param name="componentB"> Компонент B.</param>
		public ComponentMediator(ComponentA componentA, ComponentB componentB)
		{
			_componentA = componentA ?? throw new ArgumentNullException(nameof(componentA));
			_componentA.SetMediator(this);
			_componentB = componentB ?? throw new ArgumentNullException(nameof(componentB));
			_componentB.SetMediator(this);
		}

		/// <summary>
		/// Реакция медитора на действие компонентов.
		/// </summary>
		/// <param name="sender"> Источник действия.</param>
		/// <param name="actNumber"> Номер действия.</param>
		public void Notify(object sender, int actNumber)
		{
			if (actNumber == 1)
			{
				Console.WriteLine("Медиатор реагирует на действие 1");
				_componentB.Act3();
			}

			if (actNumber == 4)
			{
				Console.WriteLine("Медиатор реагирует на действие 4");
				_componentA.Act2();
			}
		}
	}
}
