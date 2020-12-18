using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	/// <summary>
	/// Наблюдатель переименования.
	/// </summary>
	public interface IRenameEventListener
	{
		/// <summary>
		/// Действи на изменнение состояния.
		/// </summary>
		/// <param name="renameStateEvent"> Событие смены названия.</param>
		void Update(IRenameEvent renameStateEvent);
	}
}
