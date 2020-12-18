using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesAbstractFactory
{
	/// <summary>
	/// Интерфейс штанов.
	/// </summary>
	public interface IPants
	{
		/// <summary>
		/// Получить размер штанов.
		/// </summary>
		/// <returns>Размер шатнов.</returns>
		string CalcSize();
	}
}
