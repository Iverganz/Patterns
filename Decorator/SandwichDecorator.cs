using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	/// <summary>
	/// Декоратор для сэндвичей.
	/// </summary>
	public abstract class SandwichDecorator : Sandwich
	{
		/// <summary>
		/// Сэндвич.
		/// </summary>
		private Sandwich _sandwich;

		/// <summary>
		/// Сэндвич.
		/// </summary>
		protected Sandwich Sandwich
		{
			get => _sandwich;
		}

		/// <summary>
		/// Возвращает экземпляр декоратора сэндвича.
		/// </summary>
		/// <param name="sandwich"> Сэндвич.</param>
		/// <param name="name"> Название.</param>
		public SandwichDecorator(Sandwich sandwich, string name) : base(name)
		{
			if (sandwich == null)
			{
				throw new ArgumentNullException(nameof(sandwich));
			}

			_sandwich = sandwich;
		}
	}
}
