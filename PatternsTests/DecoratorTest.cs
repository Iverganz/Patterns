using System;
using Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternsTests
{
	/// <summary>
	/// Тесты для декоратора.
	/// </summary>
	[TestClass]
	public class DecoratorTest
	{
		/// <summary>
		/// Тест успешного подсчета цены вегетарианского сэндвича.
		/// </summary>
		[TestMethod]
		public void CalcVegtarianSandwichCostSucccess()
		{
			Sandwich sandwich = new SeaSandwich();
			var seaSandwichPrice = sandwich.CalcCost();
			sandwich = new VegetarianSandwich(sandwich);
			var vegSandwichPrice = sandwich.CalcCost();
			Assert.IsTrue(seaSandwichPrice - vegSandwichPrice == 80);
		}

		/// <summary>
		/// Тест успешного подсчета цены сэндвича с сыром.
		/// </summary>
		[TestMethod]
		public void CalcCheeseSandwichCostSucccess()
		{
			Sandwich sandwich = new SeaSandwich();
			var seaSandwichPrice = sandwich.CalcCost();
			sandwich = new CheeseSandwich(sandwich);
			Assert.IsTrue(seaSandwichPrice - sandwich.CalcCost() == -50);
		}

		/// <summary>
		/// Тест успешного подсчета цены вегетарианского сэндвича с сыром.
		/// </summary>
		[TestMethod]
		public void CalcVegetarianCheeseSandwichCostSucccess()
		{
			Sandwich sandwich = new SeaSandwich();
			var seaSandwichPrice = sandwich.CalcCost();
			sandwich = new CheeseSandwich(sandwich);
			sandwich = new VegetarianSandwich(sandwich);
			Assert.IsTrue(seaSandwichPrice - sandwich.CalcCost() == 30);
		}

		/// <summary>
		/// Тест ошибки подсчета цены вегетарианского сэндвича.
		/// </summary>
		[TestMethod]
		public void CalcVegetarianSandwichCostFailed()
		{
			try
			{
				Sandwich sandwich = new SeaSandwich();
				var seaSandwichPrice = sandwich.CalcCost();
				sandwich = new VegetarianSandwich(sandwich);
				sandwich = new VegetarianSandwich(sandwich);
				sandwich = new VegetarianSandwich(sandwich);
				sandwich = new VegetarianSandwich(sandwich);
			}

			catch (ArgumentOutOfRangeException ex)
			{
				Assert.IsTrue(true);
			}
		}
	}
}
