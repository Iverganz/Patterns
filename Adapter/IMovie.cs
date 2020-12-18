using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	/// <summary>
	/// Интерфейс фильмов.
	/// </summary>
	public interface IMovie
	{ 
		/// <summary>
		/// Сценарий.
		/// </summary>
		string Script { get;}

	}
}
