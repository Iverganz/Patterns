using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	/// <summary>
	/// Овощной сэндвич.
	/// </summary>
	public class VegetarianSandwich : SandwichDecorator
	{
		/// <summary>
		/// Возвращает экземпляр овощного сэндвича.
		/// </summary>
		/// <param name="sandwich"> Сэндвич.</param>
		public VegetarianSandwich(Sandwich sandwich) : base(sandwich, sandwich.Name + "без продуктов животного происхождения.")
		{ }

		/// <summary>
		/// Возвращает цену сэндвича со скидкой за отстутствие мяса.
		/// </summary>
		/// <returns></returns>
		public override int CalcCost()
		{
			if (Sandwich.CalcCost() <= 80)
			{
				throw new ArgumentException("Вынули уже всё мясо");
			}

			return Sandwich.CalcCost() - 80;
		}
	}
}
