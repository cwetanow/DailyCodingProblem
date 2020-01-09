using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem369
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestMin_ShouldReturnCorrectly()
		{
			// Arrange
			var tracker = new StockTracker();
			tracker.Add(1, 2);
			tracker.Add(2, 1);
			tracker.Add(3, 3);

			var expectedResult = 1;

			// Act
			var actual = tracker.Min;

			// Assert
			actual.Should().Be(expectedResult);
		}

		[Test]
		public void TestMax_ShouldReturnCorrectly()
		{
			// Arrange
			var tracker = new StockTracker();
			tracker.Add(1, 2);
			tracker.Add(2, 1);
			tracker.Add(3, 3);

			var expectedResult = 3;

			// Act
			var actual = tracker.Max;

			// Assert
			actual.Should().Be(expectedResult);
		}

		[Test]
		public void TestAverage_ShouldReturnCorrectly()
		{
			// Arrange
			var tracker = new StockTracker();
			tracker.Add(1, 2);
			tracker.Add(2, 1);
			tracker.Add(3, 3);

			var expectedResult = 2;

			// Act
			var actual = tracker.Average;

			// Assert
			actual.Should().Be(expectedResult);
		}

		[Test]
		public void TestUpdate_ShouldUpdateCorrectly()
		{
			// Arrange
			var tracker = new StockTracker();
			tracker.Add(2, 1);
			tracker.Update(2, 5);

			var expectedResult = 5;

			// Act
			var actual = tracker.Average;

			// Assert
			actual.Should().Be(expectedResult);
		}

		[Test]
		public void TestRemove_ShouldBehaveCorrectly()
		{
			// Arrange
			var tracker = new StockTracker();
			tracker.Add(2, 1);
			tracker.Remove(2);

			var expectedResult = 0;

			// Act
			var actual = tracker.Average;

			// Assert
			actual.Should().Be(expectedResult);
		}
	}
}
