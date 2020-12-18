using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	/// <summary>
	/// Комикс.
	/// </summary>
	public class ComicsBook : IBook
	{
		/// <summary>
		/// Название комикса.
		/// </summary>
		private string _headline;

		/// <summary>
		/// Сюжет.
		/// </summary>
		public string Story
		{
			get;
			set;
		}

		/// <summary>
		/// Название комикса.
		/// </summary>
		public string Headline
		{
			get => _headline;
			set
			{
				if (String.IsNullOrWhiteSpace(value))
				{
					_headline = value;
				}

			}
		}

		/// <summary>
		/// Создает экземпляр комикса.
		/// </summary>
		/// <param name="headline"> Заголовок.</param>
		/// <param name="story"> Сюжет.</param>
		public ComicsBook(string headline, string story)
		{
			Headline = headline;
			Story = story;
		}
	}
}
