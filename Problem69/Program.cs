
namespace Problem69
{
	public class Program
	{
		public static void Main(string[] args)
		{
		}

		public static long GetLargestProduct(int[] numbers)
		{
			return GetLargestProduct(numbers, 0, 0, 1);
		}

		private static long GetLargestProduct(int[] numbers, int currentIndex, int alreadyAddedCount, long currentLargestProduct)
		{
			if (currentIndex == numbers.Length && alreadyAddedCount != 3)
			{
				return long.MinValue;
			}

			if (currentIndex == numbers.Length && alreadyAddedCount == 3)
			{
				return currentLargestProduct;
			}

			if (alreadyAddedCount == 3)
			{
				return currentLargestProduct;
			}

			var productWithAdd = GetLargestProduct(numbers, currentIndex + 1, alreadyAddedCount + 1, currentLargestProduct * numbers[currentIndex]);

			var productWithout = GetLargestProduct(numbers, currentIndex + 1, alreadyAddedCount, currentLargestProduct);

			return productWithAdd > productWithout ? productWithAdd : productWithout;
		}
	}
}
