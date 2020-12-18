using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesAbstractFactory
{
	/// <summary>
	/// Фабрика классической одежды.
	/// </summary>
	public class ClassicClothesFactory : IClothesFactory
	{
		/// <summary>
		/// Возвращает классическую верхнюю одежду.
		/// </summary>
		/// <param name="hasHood">Наличие капюшона.</param>
		/// <param name="isWarm">Утепленность.</param>
		/// <param name="material">Материал.</param>
		/// <param name="size">Размер.</param>
		/// <returns></returns>
		public IOuterwear SewOutwear(bool hasHood, bool isWarm, Material material, byte size) => new ClassicOutwear(hasHood, isWarm, material, size);

		/// <summary>
		/// Возвращает классические брюки.
		/// </summary>
		/// <param name="insideLength">Длина по внутреннему шву.</param>
		/// <param name="hipGirth">Обхват бедер.</param>
		/// <param name="seamLength">Длина по шву.</param>
		/// <returns></returns>
		public IPants SewPants(float insideLength, float hipGirth, float seamLength) => new ClassicPants(insideLength, hipGirth, seamLength);
	}
}
