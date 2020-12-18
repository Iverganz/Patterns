using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCAndDI
{
	/// <summary>
	/// Артист.
	/// </summary>
	public interface IArtist
	{
		/// <summary>
		/// Жив.
		/// </summary>
		bool IsAlive { get; set; }

		/// <summary>
		/// Богат.
		/// </summary>
		bool IsRich { get; set; }

		/// <summary>
		/// Жанр.
		/// </summary>
		string Genre { get; }

		/// <summary>
		/// Получить гонорар.
		/// </summary>
		void ReciveTerms();
	}
}
