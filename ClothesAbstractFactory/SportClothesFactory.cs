using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesAbstractFactory
{
	/// <summary>
	/// Фабрика спортивной одежды.
	/// </summary>
	public class SportClothesFactory : IClothesFactory
	{
		/// <summary>
		/// Возвращает экземпляр спортивной верхней одежды.
		/// </summary>
		/// <param name="hasHood">Наличие капюшона.</param>
		/// <param name="isWarm">Утепленность.</param>
		/// <param name="material">Материал.</param>
		/// <param name="size">Размер.</param>
		/// <returns></returns>
		public IOuterwear SewOutwear(bool hasHood,bool isWarm, Material material, byte size) => new SportOutwear(hasHood, isWarm, material, size);

		/// <summary>
		/// Возвращает экземпляр спортивных брюк.
		/// </summary>
		/// <param name="insideLength">Длина по внутреннему шву, cm.</param>
		/// <param name="hipGirth">Обхват бедер, cm.</param>
		/// <param name="seamLength">Длина, cm.</param>
		/// <returns></returns>
		public IPants SewPants(float insideLength, float hipGirth, float seamLength) => new SportPants(insideLength, hipGirth, seamLength);
	}
}
