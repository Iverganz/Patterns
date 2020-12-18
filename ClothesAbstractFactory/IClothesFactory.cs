using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesAbstractFactory
{
	/// <summary>
	/// Интерфейс фабрики одежды.
	/// </summary>
	public interface IClothesFactory
	{
		/// <summary>
		/// Возвращает экземпляр верхней одежды.
		/// </summary>
		/// <param name="hasHood">Наличие капюшона.</param>
		/// <param name="isWarm">Утепленность.</param>
		/// <param name="material">Материал.</param>
		/// <param name="size">Размер.</param>
		/// <returns></returns>
		IOuterwear SewOutwear(bool hasHood, bool isWarm, Material material, byte size);

		/// <summary>
		/// Возвращает экземпляр брюк.
		/// </summary>
		/// <param name="insideLength">Длина по внутреннему шву, cm.</param>
		/// <param name="hipGirth">Обхват бедер, cm.</param>
		/// <param name="seamLength">Длина, cm.</param>
		/// <returns></returns>
		IPants SewPants(float insideLength, float hipGirth, float seamLength);
	}
}
