using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	/// <summary>
	/// Наблюдатель в верхнем регистре.
	/// </summary>
	public class UpperCaseListener : IRenameEventListener
	{
		/// <summary>
		/// Действие на переименование.
		/// </summary>
		/// <param name="renameStateEvent"> Событие смены названия.</param>
		public void Update(IRenameEvent renameStateEvent)
		{
			Console.WriteLine(renameStateEvent.Name.ToUpper());
		}
	}
}
