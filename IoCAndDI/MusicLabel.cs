using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCAndDI
{
	/// <summary>
	/// Музыкальный лейбл.
	/// </summary>
	public abstract class MusicLabel
	{
		/// <summary>
		/// Создать звезду.
		/// </summary>
		/// <returns> Артист. </returns>
		public abstract IArtist CreateStar();
	}
}
