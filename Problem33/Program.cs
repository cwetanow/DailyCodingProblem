using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem33
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var sequence = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToArray();

			var runningMedian = ComputeRunningMedian(sequence);

			Console.WriteLine(string.Join(' ', runningMedian));
		}

		public static double[] ComputeRunningMedian(int[] sequence)
		{
			var result = new List<double>();

			var medianIndex = 0;
			for (var i = 1; i <= sequence.Length; i++)
			{
				var currentSequence = sequence
					.Take(i)
					.OrderBy(n => n)
					.ToList();

				if (i % 2 == 0)
				{
					var median = (currentSequence[medianIndex] + currentSequence[medianIndex - 1]) / 2.0;
					result.Add(median);
				}
				else
				{
					result.Add(currentSequence[medianIndex]);
					medianIndex++;
				}
			}

			return result.ToArray();
		}
	}
}
