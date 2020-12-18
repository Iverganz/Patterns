using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	/// <summary>
	/// Боевик.
	/// </summary>
	public class ActionMovie : IMovie
	{
		/// <summary>
		/// Сценарий.
		/// </summary>
		private string _script;

		/// <summary>
		/// Сценарий.
		/// </summary>
		public string Script
		{
			get => _script;
		}

		/// <summary>
		/// Конструктор с одним параметром.
		/// </summary>
		/// <param name="script">Сценарий.</param>
		public ActionMovie(string script)
		{
			if (String.IsNullOrWhiteSpace(script))
			{
				throw new ArgumentNullException(nameof(script));
			}

			_script = script;
		}
	}
}
