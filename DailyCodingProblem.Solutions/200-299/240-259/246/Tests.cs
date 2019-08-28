using System.Collections.Generic;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem246
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestCanWordsBeChained_CanBeChained_ShouldReturnTrue()
		{
			// Arrange
			var words = new List<string> {
				"chair", "height", "racket", "touch", "tunic"
			};

			// Act
			var result = Solution.CanWordsBeChained(words);

			// Assert
			Assert.IsTrue(result);
		}

		[Test]
		public void TestCanWordsBeChained_CanNotBeChained_ShouldReturnFalse()
		{
			// Arrange
			var words = new List<string> {
				"chair", "height", "racket"
			};

			// Act
			var result = Solution.CanWordsBeChained(words);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
