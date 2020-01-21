using System;
using System.Collections;
using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem166
{
	public class TwoDIterator : IEnumerable<int>
	{
		private readonly int[][] arrays;

		public TwoDIterator(int[][] arrays)
		{
			this.arrays = arrays;
		}

		public IEnumerator<int> GetEnumerator()
		{
			foreach (var array in arrays)
			{
				foreach (var element in array)
				{
					yield return element;
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
