using System.Collections.Generic;
using DailyCodingProblem.Solutions.Problem73;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem73Tests
{
	[TestFixture]
	public class ReverseTests
	{
		[Test]
		public void TestReverse_ShouldWorkCorrectly()
		{
			// Arrange
			var linkedList = new Solutions.Common.LinkedList<int>();
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
