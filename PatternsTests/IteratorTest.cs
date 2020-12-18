using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iterator;

namespace PatternsTests
{
	/// <summary>
	/// Тесты для паттерна итератор.
	/// </summary>
	[TestClass]
	public class IteratorTest
	{
		/// <summary>
		/// Тестирует обход бинарного дерева.
		/// </summary>
		[TestMethod]
		public void TreeBypassSuccess()
		{
			var rightNode = new BinaryTreeNode { Value = 5 };
			var leftNode = new BinaryTreeNode { Value = 6 };
			var root = new BinaryTreeNode { Value = 4, Left = leftNode, Right = rightNode };
			var tree = new BinaryTree(root);
			var treeBypass = "";
			LCR(tree.Root, ref treeBypass);
			string[] nodes = treeBypass.Split(',');

			var iterator = tree.CreateLCRIterator();

			foreach (var node in nodes)
			{
				Assert.IsTrue(((BinaryTreeNode)iterator.Current()).Value.ToString() == node);
				iterator.MoveNext();
			}

		}

		/// <summary>
		/// Обходит дерево, результат записывает в строку.
		/// </summary>
		/// <param name="node"> Корневой узел дерева.</param>
		/// <param name="s"> Результат обхода.</param>
		private void LCR(BinaryTreeNode node, ref string s)
		{
			if (node != null)
			{
				LCR(node.Left, ref s);
				s += "," + node.Value.ToString();
				LCR(node.Right, ref s);
				s = s.TrimStart(',');
			}
		}
	}
}
