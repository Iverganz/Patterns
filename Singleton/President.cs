using System;
using System.Security.Cryptography;

namespace Singleton
{
	/// <summary>
	/// Президент.
	/// </summary>
	public class President
	{
		/// <summary>
		/// Экземпляр Singleton.
		/// </summary>
		private static President _president;

		/// <summary>
		/// Объект блокировки для безопасного использования многопоточности. 
		/// </summary>
		private static readonly object _instanceLock = new Object();

		/// <summary>
		/// Получение экземпляра Singleton.
		/// </summary>
		public static President Instance
		{
			get
			{
				if (_president == null)
				{
					lock (_instanceLock)
					{
						if (_president == null)
						{
							_president = new President();
						}

						return _president;
					}
				}
				return _president;
			}
		}

		/// <summary>
		/// Имя.
		/// </summary>
		public string Name
		{
			get;
		}

		/// <summary>
		/// Конструктор без параметров.
		/// </summary>
		private President()
		{
			Name = "Владимир Владимирович";
		}
	}
}