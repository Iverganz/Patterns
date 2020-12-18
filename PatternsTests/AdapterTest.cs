using System;
using Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternsTests
{
	/// <summary>
	/// Тесты для адаптера.
	/// </summary>
	[TestClass]
	public class AdapterTest
	{
		/// <summary>
		/// Проверяет корректность работы адаптера.
		/// </summary>
		[TestMethod]
		public void AdapterTestSuccess()
		{
			var script = "сценарий";
			IMovie actionMovie = new ActionMovie(script);
			var tittle = "tittle";
			var story = "канон";
			ComicsBook comics = new ComicsBook(tittle, story);
			IMovie comicsMovie = new BookToMovieAdapter(comics);
			Assert.IsTrue(script.Equals(actionMovie.Script) && story.Equals(comicsMovie.Script));
		}
	}
}
