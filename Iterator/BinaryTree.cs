using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	public class BinaryTree : IIterableCollection
	{
		/// <summary>
		/// Элемент дерева.
		/// </summary>
		private BinaryTreeNode _root;

		/// <summary>
		/// Элемент дерева.
		/// </summary>
		public BinaryTreeNode Root
		{
			get => _root;
			set => _root = value ?? throw new ArgumentNullException(nameof(value));
		}

		/// <summary>
		/// Создает Итератор центрированного обхода.
		/// </summary>
		/// <returns> Итератор центрированного обхода. </returns>
		public IIterator CreateLCRIterator()
		{
			return new LCRIterator(this);
		}

		/// <summary>
		/// Конструктор.
		/// </summary>
		public BinaryTree(BinaryTreeNode root)
		{
			Root = root;
		}
	}

	/// <summary>
	/// Элемент дерева.
	/// </summary>
	public class BinaryTreeNode
	{
		/// <summary>
		/// Значение.
		/// </summary>
		public int Value { get; set; }

		/// <summary>
		/// Левое дерево.
		/// </summary>
		public BinaryTreeNode Left { get; set; }

		/// <summary>
		/// Правое дерево.
		/// </summary>
		public BinaryTreeNode Right { get; set; }
	}
}
