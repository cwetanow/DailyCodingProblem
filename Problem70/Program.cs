using System;

namespace Problem70
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public static int GetNthPerfectNumber(int n)
		{
			var counter = 19;
			while (true)
			{
				if (IsPerfectNumber(counter))
				{
					n--;
				}

				if (n == 0)
				{
					return counter;
				}

				counter++;
			}
		}

		private static bool IsPerfectNumber(int number)
		{
			var sum = 0;

			while (number > 0)
			{
				sum += (number % 10);
				number /= 10;

				if (sum > 10)
				{
					return false;
				}
			}

			if (sum == 10)
			{
				return true;
			}

			return false;
		}
	}
}
