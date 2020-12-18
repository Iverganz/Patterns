using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	/// <summary>
	/// Адаптер книги в фильм.
	/// </summary>
	public class BookToMovieAdapter : IMovie
	{
		/// <summary>
		/// Комикс.
		/// </summary>
		private readonly IBook _comics;

		/// <summary>
		/// Конструктор с одним параметром.
		/// </summary>
		/// <param name="comics"></param>
		public BookToMovieAdapter(IBook comics)
		{
			if (comics == null)
			{
				throw new ArgumentNullException(nameof(comics));
			}

			_comics = comics;
		}

		/// <summary>
		/// Сценарий.
		/// </summary>
		public string Script
		{
			get => _comics.Story;
		}
	}
}
