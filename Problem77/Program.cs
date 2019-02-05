using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem77
{
	public class Program
	{
		public static void Main(string[] args)
		{
		}

		public static IEnumerable<(int start, int end)> MergeOverlappingIntervals(IEnumerable<(int start, int end)> input)
		{
			var result = new List<(int start, int end)>();

			foreach (var (start, end) in input)
			{
				if (!input.Any(el => el.start < start && el.end > end))
				{
					result.Add((start, end));
				}
			}

			return result;
		}
	}
}
