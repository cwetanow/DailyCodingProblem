using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem267
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestIsKingInCheck_BishopIsHitting_ShouldReturnTrue()
		{
			// Arrange
			var board = new[]
			{
				new [] { '.', '.', '.', 'K', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', 'B', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', 'P','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','R' },
				new [] { '.', '.', 'N', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', 'Q', '.','.' }
			};

			// Act
			var isInCheck = Solution.IsKingInCheck(board);

			// Assert
			Assert.IsTrue(isInCheck);
		}
		[Test]
		public void TestIsKingInCheck_RookIsHitting_ShouldReturnTrue()
		{
			// Arrange
			var board = new[]
			{
				new [] { '.', '.', '.', 'K', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', 'P','.' },
				new [] { '.', '.', '.', 'R', '.', '.', '.','R' },
				new [] { '.', '.', 'N', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', 'Q', '.','.' }
			};

			// Act
			var isInCheck = Solution.IsKingInCheck(board);

			// Assert
			Assert.IsTrue(isInCheck);
		}

		[Test]
		public void TestIsKingInCheck_NightIsHitting_ShouldReturnTrue()
		{
			// Arrange
			var board = new[]
			{
				new [] { '.', '.', '.', 'K', '.', '.', '.','.' },
				new [] { '.', 'N', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', 'P','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','R' },
				new [] { '.', '.', 'N', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', 'Q', '.','.' }
			};

			// Act
			var isInCheck = Solution.IsKingInCheck(board);

			// Assert
			Assert.IsTrue(isInCheck);
		}

		[Test]
		public void TestIsKingInCheck_QueenIsHittingDiagonally_ShouldReturnTrue()
		{
			// Arrange
			var board = new[]
			{
				new [] { '.', '.', '.', 'K', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', 'Q', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', 'P','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','R' },
				new [] { '.', '.', 'N', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', 'Q', '.','.' }
			};

			// Act
			var isInCheck = Solution.IsKingInCheck(board);

			// Assert
			Assert.IsTrue(isInCheck);
		}

		[Test]
		public void TestIsKingInCheck_QueenIsHittingByRow_ShouldReturnTrue()
		{
			// Arrange
			var board = new[]
			{
				new [] { '.', 'Q', '.', 'K', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', 'P','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','R' },
				new [] { '.', '.', 'N', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', 'Q', '.','.' }
			};

			// Act
			var isInCheck = Solution.IsKingInCheck(board);

			// Assert
			Assert.IsTrue(isInCheck);
		}

		[Test]
		public void TestIsKingInCheck_PawnIsHitting_ShouldReturnTrue()
		{
			// Arrange
			var board = new[]
			{
				new [] { '.', '.', '.', 'K', '.', '.', '.','.' },
				new [] { '.', '.', 'P', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', 'P','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','R' },
				new [] { '.', '.', 'N', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', 'Q', '.','.' }
			};

			// Act
			var isInCheck = Solution.IsKingInCheck(board);

			// Assert
			Assert.IsTrue(isInCheck);
		}

		[Test]
		public void TestIsKingInCheck_IsNotInCheck_ShouldReturnFalse()
		{
			// Arrange
			var board = new[]
			{
				new [] { '.', '.', '.', 'K', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { 'B', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', 'P','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','R' },
				new [] { '.', '.', 'N', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', '.', '.','.' },
				new [] { '.', '.', '.', '.', '.', 'Q', '.','.' }
			};

			// Act
			var isInCheck = Solution.IsKingInCheck(board);

			// Assert
			Assert.IsFalse(isInCheck);
		}
	}
}
