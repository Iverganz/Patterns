using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	public abstract class BaseComponent
	{
		/// <summary>
		///  Медиатор.
		/// </summary>
		protected IMediator Mediator { get; private set; }

		/// <summary>
		/// Устанавливает экземпляр посредника у текущего компонента.
		/// </summary>
		/// <param name="mediator"> Медиатор.</param>
		public void SetMediator(IMediator mediator)
		{
			Mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
		}
	}
}
