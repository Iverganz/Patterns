using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCAndDI
{
	/// <summary>
	/// РОк звезда.
	/// </summary>
	public class RockStar : IArtist
	{
		/// <summary>
		/// Конструтор по умолчанию.
		/// </summary>
		public RockStar ()
		{
			IsAlive = true;
			IsRich = false;
		}

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
		public string Genre => "Rock";

		/// <summary>
		/// Получить гонорар.
		/// </summary>
		public void ReciveTerms()
		{
			IsAlive = false;
			IsRich = true;
		}
	}
}
