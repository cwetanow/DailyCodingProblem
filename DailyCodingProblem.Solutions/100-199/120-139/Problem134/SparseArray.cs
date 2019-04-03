using System;
using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem134
{
	public class SparseArray
	{
		private readonly IDictionary<int, int> sparseArray = new Dictionary<int, int>();
		private int size;

		public void Init(int[] array, int size)
		{
			this.size = size;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != 0)
				{
					this.sparseArray.Add(i, array[i]);
				}
			}
		}

		public void Set(int index, int value)
		{
			if (index >= this.size)
			{
				throw new IndexOutOfRangeException();
			}

			if (this.sparseArray.ContainsKey(index))
			{
				this.sparseArray.Remove(index);
			}

			this.sparseArray.Add(index, value);
		}

		public int Get(int index)
		{
			if (index >= this.size)
			{
				throw new IndexOutOfRangeException();
			}

			if (this.sparseArray.TryGetValue(index, out int value))
			{
				return value;
			}
			else
			{
				return 0;
			}
		}
	}
}
