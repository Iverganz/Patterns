using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	/// <summary>
	/// Состояние приложения.
	/// </summary>
	public class AppState : IRenameEvent
	{
		/// <summary>
		/// Название состояния.
		/// </summary>
		private string _appStateName;

		/// <summary>
		/// Название состояния.
		/// </summary>
		public string Name
		{
			get
			{
				return _appStateName;
			}

			set
			{
				_appStateName = value ?? throw new ArgumentNullException(nameof(Name));
				NotifyListeners();
			}
		}

		/// <summary>
		/// Список наблюдателей.
		/// </summary>
		private List<IRenameEventListener> _listeners = new List<IRenameEventListener>();

		/// <summary>
		/// Добавление наблюдателя.
		/// </summary>
		/// <param name="listener"> Наблюдатель.</param>
		public void AddListener(IRenameEventListener listener)
		{
			if (listener == null)
			{
				throw new ArgumentNullException(nameof(listener));
			}

			_listeners.Add(listener);
		}

		/// <summary>
		/// Оповещение наблюдателей.
		/// </summary>
		public void NotifyListeners()
		{
			foreach (var listener in _listeners)
			{
				listener.Update(this);
			}
		}

		/// <summary>
		/// Удаление наблюдателя.
		/// </summary>
		/// <param name="listener"> Наблюдатель.</param>
		public void RemoveListener(IRenameEventListener listener)
		{
			if (listener == null)
			{
				throw new ArgumentNullException(nameof(listener));
			}

			_listeners.Remove(listener);
		}

		public AppState (string name)
		{
			Name = name;
		}
	}
}
