using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem368
{
	public class KeyValueStore
	{
		private readonly IDictionary<int, int> store = new Dictionary<int, int>();
		private readonly IDictionary<int, int> maxKeys = new Dictionary<int, int>();

		public void Update(int key, int value)
		{
			if (store.ContainsKey(key))
			{
				store[key] = value;
			}
			else
			{
				store.Add(key, value);
			}

			if (maxKeys.ContainsKey(value) && maxKeys[value] < key)
			{
				maxKeys[value] = key;
			}
			else
			{
				maxKeys.Add(value, key);
			}
		}

		public int? Get(int key)
		{
			if (store.TryGetValue(key, out var value))
			{
				return value;
			}

			return null;
		}

		public int? MaxKey(int value)
		{
			if (maxKeys.TryGetValue(value, out var key))
			{
				return key;
			}

			return null;
		}
	}
}
