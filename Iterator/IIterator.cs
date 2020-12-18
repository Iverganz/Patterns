using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	/// <summary>
	/// Интерефейс оператора.
	/// </summary>
	public interface IIterator
	{
		/// <summary>
		/// Получение следующего элемента.
		/// </summary>
		/// <returns> Наличие следующего элемента.</returns>
		bool MoveNext();

		/// <summary>
		/// Текущий элемент.
		/// </summary>
		/// <returns></returns>
		object Current();

		/// <summary>
		/// Возвращается к первому элементу.
		/// </summary>
		void Reset();
	}
}
