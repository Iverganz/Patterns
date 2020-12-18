using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCAndDI
{
	/// <summary>
	/// Поп музыкальный лейбл.
	/// </summary>
	public class PopMusicLabel : MusicLabel
	{
		/// <summary>
		/// Создать звезду.
		/// </summary>
		/// <returns>Поп-звезда.</returns>
		public override IArtist CreateStar()
		{
			return new PopStar();
		}
	}
}
