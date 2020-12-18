using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoCAndDI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternsTests
{
	/// <summary>
	/// Тесты для паттерна инверсия зависимостей.
	/// </summary>
	[TestClass]
	public class DITest
	{
		/// <summary>
		/// Тест успешной работы паттерна инверсия зависимостей.
		/// </summary>
		[TestMethod]
		public void DITestSuccess()
		{
			MusicLabel label = new RockMusicLabel();
			var rockStar = label.CreateStar();
			rockStar.ReciveTerms();
			Assert.IsFalse(rockStar.IsAlive && rockStar.IsRich);

			label = new PopMusicLabel();
			var popStar = label.CreateStar();
			popStar.ReciveTerms();
			Assert.IsTrue(popStar.IsRich && popStar.IsAlive);

		}
	}
}
