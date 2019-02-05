using NUnit.Framework;
using System.Collections.Generic;

namespace Tests.Problem73Tests
{
	[TestFixture]
	public class ReverseTests
	{
		[Test]
		public void TestReverse_ShouldWorkCorrectly()
		{
			// Arrange
			var linkedList = new Problem73.LinkedList<int>();
			var list = new List<int>();

			for (int i = 0; i < 10; i++)
			{
				linkedList.Add(i);
				list.Add(i);
			}

			list.Reverse();

			// Act 
			linkedList.Reverse();

			// Assert
			CollectionAssert.AreEqual(list, linkedList.ToList());
		}
	}
}
