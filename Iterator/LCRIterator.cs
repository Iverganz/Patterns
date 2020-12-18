using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	/// <summary>
	/// Итератор центрированного обхода.
	/// </summary>
	public class LCRIterator : IIterator
	{
		/// <summary>
		/// Текущий индекс.
		/// </summary>
		private int _current = 0;

		/// <summary>
		/// Узлы дерева в порядке обхода.
		/// </summary>
		private List<object> _bypass = new List<object>();

		public LCRIterator(BinaryTree tree)
		{
			getBypass(tree.Root);
		}

		/// <summary>
		/// Текущий элемент.
		/// </summary>
		/// <returns></returns>
		public object Current()
		{
			return _bypass[_current];
		}

		/// <summary>
		/// Возвращает следующий элемент.
		/// </summary>
		/// <returns> Следующий элемент.</returns>
		public bool MoveNext()
		{
			if (_current + 1 < _bypass.Count)
			{
				_current++;
			}

			return _current < _bypass.Count;
		}

		/// <summary>
		/// Возвращается к первому элементу.
		/// </summary>
		public void Reset()
		{
			_current = 0;
		}

		/// <summary>
		/// Совершает обход дерева.
		/// </summary>
		/// <param name="root"> Корневой узел.</param>
		private void getBypass(BinaryTreeNode root)
		{
			if (root != null)
			{
				getBypass(root.Left);
				_bypass.Add(root);
				getBypass(root.Right);
			}
		}
	}
}
