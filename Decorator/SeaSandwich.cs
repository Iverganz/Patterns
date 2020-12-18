using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	/// <summary>
	/// Сэндвич с морепродуктами.
	/// </summary>
	public class SeaSandwich : Sandwich
	{
		/// <summary>
		/// Возвращает экземпляр сндвича с морепродуктами.
		/// </summary>
		public SeaSandwich() : base("Сэндвич с морепродуктами.")
		{ }

		/// <summary>
		/// Возвращает стоимость сендвича с морепродуктами.
		/// </summary>
		/// <returns> Стоимость.</returns>
		public override int CalcCost()
		{
			return 200;
		}
	}
}
