using System.Collections.Generic;
using System.Linq;

namespace Problem40
{
	public class Program
	{
		public static void Main(string[] args)
		{
		}

		public static int GetNonDuplicatedInteger(IEnumerable<int> input)
		{
			var map = new HashSet<int>();

			var results = new HashSet<int>();

			foreach (var element in input)
			{
				if (!map.Contains(element))
				{
					results.Add(element);
					map.Add(element);
				}
				else
				{
					if (results.Contains(element))
					{
						results.Remove(element);
					}
				}
			}

			return results.First();
		}
	}
}
