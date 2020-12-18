using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	/// <summary>
	/// Интерфейс книги.
	/// </summary>
	public interface IBook
	{
		/// <summary>
		/// Название.
		/// </summary>
		string Headline { get; set; }
		
		/// <summary>
		/// Сюжет.
		/// </summary>
		string Story { get; set; }
	}
}
