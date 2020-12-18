using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesAbstractFactory
{
	/// <summary>
	/// Верхняя одежда.
	/// </summary>
	public interface IOuterwear
	{
		/// <summary>
		/// Вычисляет цену верхней одежды.
		/// </summary>
		/// <returns>Цена.</returns>
		int CalcPrice();
	}
}
