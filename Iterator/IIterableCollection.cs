using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	interface IIterableCollection
	{
		/// <summary>
		/// Возвращает Итератор центрированного обхода.
		/// </summary>
		/// <returns> Экземпляр итератора.</returns>
		IIterator CreateLCRIterator();
	}
}
