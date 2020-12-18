using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	/// <summary>
	/// Наблюдатель в нижнем регистре.
	/// </summary>
	public class DownCaseListener : IRenameEventListener
	{
		/// <summary>
		/// Действие на переименование.
		/// </summary>
		/// <param name="renameStateEvent"> </param>
		public void Update(IRenameEvent renameStateEvent)
		{
			Console.WriteLine(renameStateEvent.Name.ToLower());
		}
	}
}
