namespace Problem88
{
	public class Program
	{
		static void Main(string[] args)
		{
		}

		public static int Divide(int divident, int divisor)
		{
			var quotient = 0;

			while (divident >= divisor)
			{
				quotient++;
				divident -= divisor;
			}

			return quotient;
		}
	}
}
