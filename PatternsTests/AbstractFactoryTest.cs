using System;
using ClothesAbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternsTests
{
	/// <summary>
	/// Тесты абстрактной фабрики.
	/// </summary>
	[TestClass]
	public class AbstractFactoryTest
	{
		/// <summary>
		/// Проверка подсчета размера штанов разных фабрик.
		/// </summary>
		[TestMethod]
		public void CalcPantsSizeSuccess()
		{
			var sportPants = CreatePantsByFactory(new SportClothesFactory(), 80, 120, 100);
			var classicPants = CreatePantsByFactory(new ClassicClothesFactory(), 80, 120, 100);
			Assert.AreNotEqual(sportPants.CalcSize(), classicPants.CalcSize());
		}

		/// <summary>
		/// Проверка подсчета цены верхней одежды разных фабрик.
		/// </summary>
		[TestMethod]
		public void CalcOutwearCostSuccess()
		{
			var classicOutwear = CreateOutwearByFactory(new ClassicClothesFactory(), true, false, Material.Polymer, 46);
			var sportOutwear = CreateOutwearByFactory(new SportClothesFactory(), true, false, Material.Polymer, 46);
			Assert.AreNotEqual(classicOutwear.CalcPrice(), sportOutwear.CalcPrice());
		}

		/// <summary>
		/// Создает объекты штанов заданной фабрики.
		/// </summary>
		/// <param name="clothesFactory">Фабрика одежды.</param>
		/// <param name="insideLength">Длина брюк по внутренему шву.</param>
		/// <param name="hipGirth">Обхват бедер.</param>
		/// <param name="seamLength">Длина брюк по шву.</param>
		private static IPants CreatePantsByFactory(
			IClothesFactory clothesFactory,
			float insideLength,
			float hipGirth,
			float seamLength)
		{
			var pants = clothesFactory.SewPants(insideLength, hipGirth, seamLength);
			return pants;
		}

		/// <summary>
		/// Создает объект верхней одежды заданной фабрики.
		/// </summary>
		/// <param name="clothesFactory">Фабрика одежды.</param>
		/// <param name="hasHood">Наличие капюшона.</param>
		/// <param name="isWarm">Утепленность.</param>
		/// <param name="material">Материал.</param>
		/// <param name="size">Размер верхней одежды.</param>
		private static IOuterwear CreateOutwearByFactory(
			IClothesFactory clothesFactory,
			bool hasHood,
			bool isWarm,
			Material material,
			byte size)
		{
			var outwear = clothesFactory.SewOutwear(hasHood, isWarm, material, size);

			return outwear;
		}
	}
}
