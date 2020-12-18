using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCAndDI
{
	/// <summary>
	/// Рок музыкальный лейбл.
	/// </summary>
	public class RockMusicLabel : MusicLabel
	{
		/// <summary>
		/// Создать звезду.
		/// </summary>
		/// <returns>Рок-звезда.</returns>
		public override IArtist CreateStar()
		{
			return new RockStar();
		}

	}
}
