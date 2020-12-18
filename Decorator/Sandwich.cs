using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	/// <summary>
	/// Сэндвич.
	/// </summary>
	public abstract class Sandwich
	{
		/// <summary>
		/// Название.
		/// </summary>
		private string _name;

		/// <summary>
		/// Название.
		/// </summary>
		public string Name
		{
			get => _name;
		}

		/// <summary>
		/// Конструктор принимающий 1 параметр.
		/// </summary>
		/// <param name="name"></param>
		public Sandwich(string name)
		{
			if (String.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException(nameof(name));
			}

			_name = name;
		}

		/// <summary>
		/// Подсчитывает цену сэндвича.
		/// </summary>
		/// <returns>Цена сэндвича.</returns>
		public abstract int CalcCost();
	}
}
