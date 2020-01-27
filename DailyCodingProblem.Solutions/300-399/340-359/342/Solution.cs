using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem342
{
	public class Solution
	{
		public static T Reduce<T>(IList<T> list, Func<T, T, T> combiningFunc, T intialValue)
		{
			if (!list.Any())
			{
				return intialValue;
			}

			var result = combiningFunc.Invoke(intialValue, list.First());

			for (var i = 1; i < list.Count; i++)
			{
				result = combiningFunc.Invoke(result, list[i]);
			}

			return result;
		}
	}
}
