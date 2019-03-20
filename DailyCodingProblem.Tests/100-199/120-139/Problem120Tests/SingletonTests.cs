using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem120Tests
{
	[TestFixture]
	public class SingletonTests
	{
		[TestCase(1, 2)]
		[TestCase(5, 20)]
		public void TestSingleton_OnOddCall_ShouldReturnCorrectSingleton(int evenId, int oddId)
		{
			// Arrange
			Solutions.Problem120.Singleton.Reset();

			Solutions.Problem120.Singleton.InitializeSingletons(evenId, oddId);

			// Act
			var instanceId = Solutions.Problem120.Singleton.GetInstance().Id;

			// Assert
			Assert.AreEqual(oddId, instanceId);
		}

		[TestCase(1, 2)]
		[TestCase(5, 20)]
		public void TestSingleton_OnEvenCall_ShouldReturnCorrectSingleton(int evenId, int oddId)
		{
			// Arrange
			Solutions.Problem120.Singleton.Reset();

			Solutions.Problem120.Singleton.InitializeSingletons(evenId, oddId);
			Solutions.Problem120.Singleton.GetInstance();

			// Act
			var instanceId = Solutions.Problem120.Singleton.GetInstance().Id;

			// Assert
			Assert.AreEqual(evenId, instanceId);
		}
	}
}
