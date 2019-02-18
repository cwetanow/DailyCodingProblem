using NUnit.Framework;
using DailyCodingProblem.Tests.Problem26Tests.Mock;

namespace DailyCodingProblem.Tests.Problem26Tests
{
	[TestFixture]
	public class AddTests
	{
		[TestCase(1)]
		[TestCase(2)]
		[TestCase(1234)]
		public void TestAdd_ShouldAddElementToList(int element)
		{
			// Arrange
			var list = new ExtendedWithContainsLinkedList<int>();

			// Act
			list.Add(element);

			// Assert
			Assert.IsTrue(list.Contains(element));
		}
	}
}
