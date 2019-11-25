using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem368
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestKeyValueStore_ShouldReturnCorrectly()
		{
			// Arrange
			var store = new KeyValueStore();
			store.Update(1, 1);
			store.Update(2, 1);

			var expectedMaxKey = 2;

			// Act
			var actualMaxKey = store.MaxKey(1);

			// Assert
			actualMaxKey.Should().Be(expectedMaxKey);
		}
	}
}
