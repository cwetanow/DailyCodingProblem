using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem367
{
	public class Solution
	{
		public static IEnumerable<int> MergeIterators(IEnumerator<int> first, IEnumerator<int> second)
		{
			var firstAny = first.MoveNext();
			var secondAny = second.MoveNext();

			while (firstAny || secondAny)
			{
				int current;

				if (firstAny && secondAny)
				{
					if (first.Current < second.Current)
					{
						current = first.Current;
						firstAny = first.MoveNext();
					}
					else
					{
						current = second.Current;
						secondAny = second.MoveNext();
					}
				}
				else if (firstAny)
				{
					current = first.Current;
					firstAny = first.MoveNext();
				}
				else
				{
					current = second.Current;
					secondAny = second.MoveNext();
				}

				yield return current;
			}
		}
	}
}
