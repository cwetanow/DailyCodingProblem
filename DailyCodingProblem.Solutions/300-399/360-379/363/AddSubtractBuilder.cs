namespace DailyCodingProblem.Solutions.Problem363
{
	public class AddSubtractBuilder
	{
		private int result;
		private bool isAddNext = true;

		private AddSubtractBuilder(int initialNumber)
		{
			this.result = initialNumber;
		}

		public AddSubtractBuilder Append(int number)
		{
			result += isAddNext ? number : -number;
			isAddNext = !isAddNext;

			return this;
		}

		public int Compute()
		{
			return this.result;
		}

		public static AddSubtractBuilder Create(int initialNumber) => new AddSubtractBuilder(initialNumber);
	}
}
