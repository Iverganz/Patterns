using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Singleton;

namespace PatternsTests
{
	/// <summary>
	/// Тесты для одиночки.
	/// </summary>
	[TestClass]
	public class SingletonTest
	{
		/// <summary>
		/// Проверяет корректность работы одиночки.
		/// </summary>
		[TestMethod]
		public void SingletonTestSuccess()
		{
			var president1 = President.Instance;
			var president2 = President.Instance;

			Assert.IsTrue(president1 == president2);
		}
	}
}
