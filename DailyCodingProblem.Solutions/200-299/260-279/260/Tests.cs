using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem260
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestReconstructArray_ShouldReturnCorrectly()
		{
			// Arrange
			var clues = new[]
			{
				' ', '+', '+', '-', '+'
			};

			// Act
			var reconstruction = Solution.ReconstructArray(clues);

			// Assert
			Assert.IsTrue(IsReconstructionValid(clues, reconstruction));
		}

		private bool IsReconstructionValid(char[] clues, int[] reconstruction)
		{
			for (int i = 1; i < reconstruction.Length; i++)
			{
				if (clues[i] == Solution.Greater && reconstruction[i] <= reconstruction[0])
				{
					return false;
				}

				if (clues[i] == Solution.Lesser && reconstruction[i] >= reconstruction[0])
				{
					return false;
				}
			}

			return true;
		}
	}
}
