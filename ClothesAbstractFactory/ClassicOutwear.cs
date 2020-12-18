using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesAbstractFactory
{
	/// <summary>
	/// Классическая верхняя одежда.
	/// </summary>
	class ClassicOutwear : IOuterwear
	{
		/// <summary>
		/// Наличие капюшона.
		/// </summary>
		private readonly bool _hasHood;

		/// <summary>
		/// Утепленность.
		/// </summary>
		private readonly bool _isWarm;

		/// <summary>
		/// Материал.
		/// </summary>
		private readonly Material _material;

		/// <summary>
		/// Размер.
		/// </summary>
		private readonly byte _size;

		/// <summary>
		/// Конструктор с 4 входными параметрами.
		/// </summary>
		/// <param name="hasHood">Наличие капюшона.</param>
		/// <param name="isWarm">Утепленность.</param>
		/// <param name="material">Материал.</param>
		/// <param name="size">Размер.</param>
		public ClassicOutwear(bool hasHood, bool isWarm, Material material, byte size)
		{
			if (size < 20 || size > 70)
			{
				throw new ArgumentOutOfRangeException(nameof(size));
			}

			_size = size;
			_material = material;
			_isWarm = isWarm;
			_hasHood = hasHood;
		}

		/// <summary>
		/// Вычисляет цену верхней одежды.
		/// </summary>
		/// <returns>Цена.</returns>
		public int CalcPrice()
		{
			var price = 0;

			switch (_material)
			{
				case Material.Cotton:
					price = 800;
					break;
				case Material.Polymer:
					price = 1200;
					break;
				case Material.Wool:
					price = 1600;
					break;
				case Material.Fur:
					price = 2000;
					break;
				case Material.Denim:
					price = 1000;
					break;
				default:
					break;
			}

			price *= _isWarm
				? 2
				: 1;

			return price;
		}
	}
}
