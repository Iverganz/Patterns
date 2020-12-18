using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCAndDI
{
	/// <summary>
	/// Поп-звезда.
	/// </summary>
	public class PopStar : IArtist
	{
		/// <summary>
		/// Жив.
		/// </summary>
		public bool IsAlive { get; set; }

		/// <summary>
		/// Богат.
		/// </summary>
		public bool IsRich { get; set; }

		/// <summary>
		/// Жанр.
		/// </summary>
		public string Genre => "Pop";

		/// <summary>
		/// Получить гонорар.
		/// </summary>
		public void ReciveTerms()
		{
			IsRich = true;
			IsAlive = true;
		}
	}
}
