using System;
using Problem16;

namespace DailyCodingProblem.Solutions.Problem16
{
	public class Solution
	{
		public static void Test()
		{
			var n = 10;

			var service = new OrderLogService(n);

			var totalItems = 15;

			for (var j = 0; j < totalItems; j++)
			{
				service.Record(j);
			}

			var i = 5;

			var ithOrderId = service.GetLast(i);

			Console.WriteLine(ithOrderId);
		}
	}
}
