using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	/// <summary>
	/// Событие смены названия.
	/// </summary>
	public interface IRenameEvent
	{
		/// <summary>
		/// Название.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Добавление наблюдателя.
		/// </summary>
		/// <param name="listener"> Наблюдатель.</param>
		void AddListener(IRenameEventListener listener);

		/// <summary>
		/// Удаление наблюдателя.
		/// </summary>
		/// <param name="listener"> Наблюдатель.</param>
		void RemoveListener(IRenameEventListener listener);

		/// <summary>
		/// Оповещение наблюдателей.
		/// </summary>
		void NotifyListeners();
	}
}
