using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	/// <summary>
	/// Интерфейс медиатора.
	/// </summary>
	public interface IMediator
	{
		/// <summary>
		/// Осуществляет кооперацию между действиями.
		/// </summary>
		/// <param name="sender"> Источник оповещения.</param>
		/// <param name="actNumber"> Номер действия.</param>
		void Notify(object sender, int actNumber);
	}
}
