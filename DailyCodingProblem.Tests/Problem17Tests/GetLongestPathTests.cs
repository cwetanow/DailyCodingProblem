using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem17Tests
{
	[TestFixture]
	public class GetLongestPathTests
	{
		[TestCase(@"dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext", @"dir/subdir2/subsubdir2/file2.ext")]
		public void TestGetLongestPath_ShouldReturnCorrectLongestPath(string path, string expectedLongestPath)
		{
			// Arrange, Act
			var (longestPath, _) = Solutions.Problem17.Solution.GetLongestPath(path);

			// Assert
			Assert.AreEqual(expectedLongestPath, longestPath);
		}

		[TestCase(@"dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext", 32)]
		public void TestGetLongestPath_ShouldReturnCorrectLongestPathLength(string path, string expectedLength)
		{
			// Arrange, Act
			var (_, length) = Solutions.Problem17.Solution.GetLongestPath(path);

			// Assert
			Assert.AreEqual(expectedLength, length);
		}

		[Test]
		public void TestGetLongestPath_EmptyInput_ShouldReturnCorrectLongestPath()
		{
			// Arrange
			var path = string.Empty;
			var expectedLongestPath = string.Empty;

			// Act
			var (longestPath, _) = Solutions.Problem17.Solution.GetLongestPath(path);

			// Assert
			Assert.AreEqual(expectedLongestPath, longestPath);
		}

		[Test]
		public void TestGetLongestPath_EmptyInput_ShouldReturnCorrectLongestPathLength()
		{
			// Arrange
			var path = string.Empty;
			var expectedLongestPathLength = 0;

			// Act
			var (_, longestPathLength) = Solutions.Problem17.Solution.GetLongestPath(path);

			// Assert
			Assert.AreEqual(expectedLongestPathLength, longestPathLength);
		}
	}
}
