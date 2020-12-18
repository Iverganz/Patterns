using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	/// <summary>
	/// Сырный сэндвич.
	/// </summary>
	public class CheeseSandwich : SandwichDecorator
	{
		/// <summary>
		/// Возвращает экземпляр сендвича с добавлением сыра.
		/// </summary>
		/// <param name="sandwich">Сэндвич.</param>
		public CheeseSandwich(Sandwich sandwich) : base(sandwich, sandwich.Name + "с сыром")
		{ }

		/// <summary>
		/// Подсчет цены сэндвича.
		/// </summary>
		/// <returns> Цена сэндвича.</returns>
		public override int CalcCost()
		{
			if (Sandwich == null)
			{
				throw new ArgumentNullException(nameof(Sandwich));
			}
			return Sandwich.CalcCost() + 50;
		}
	}
}
