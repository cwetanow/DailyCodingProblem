using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem356
{
	public class FixedLengthArraysQueue<T>
	{
		private readonly IList<T[]> arrays;

		private int lastArrayIndex = 0;
		private int lastElementInArrayIndex = 0;

		private int firstArrayIndex = 0;
		private int firstElementInArrayIndex = 0;

		public FixedLengthArraysQueue(IList<T[]> arrays)
		{
			if (!arrays.Any() || arrays.Any(a => !a.Any()))
			{
				throw new ArgumentException("Empty array");
			}

			this.arrays = arrays;
		}

		public void Enqueue(T item)
		{
			if (lastElementInArrayIndex == arrays[lastArrayIndex].Length)
			{
				lastElementInArrayIndex = 0;
				lastArrayIndex++;
			}

			if (lastArrayIndex == arrays.Count)
			{
				lastArrayIndex = 0;
				lastElementInArrayIndex = 0;
			}

			arrays[lastArrayIndex][lastElementInArrayIndex] = item;

			lastElementInArrayIndex++;
			Size++;
		}

		public T Dequeue()
		{
			if (firstElementInArrayIndex == arrays[firstArrayIndex].Length)
			{
				firstElementInArrayIndex = 0;
				firstArrayIndex++;
			}

			if (firstArrayIndex == arrays.Count)
			{
				firstArrayIndex = 0;
				firstElementInArrayIndex = 0;
			}

			var item = arrays[firstArrayIndex][firstElementInArrayIndex];

			firstElementInArrayIndex++;
			Size--;

			return item;
		}

		public int Size { get; private set; }
	}
}
