using System.Collections.Generic;

namespace DailyCodingProblem.Solutions.Problem16
{
	public class OrderLogService
	{
		private readonly LinkedList<int> log = new LinkedList<int>();

		public OrderLogService(int maxItems)
		{
			MaxItems = maxItems;
		}

		public int MaxItems { get; set; }

		public void Record(int orderId)
		{
			if (log.Count == this.MaxItems)
			{
				log.RemoveFirst();
			}

			log.AddLast(orderId);
		}

		public int GetLast(int i)
		{
			var lastNode = log.Last;

			while (i > 0)
			{
				lastNode = lastNode.Previous;
				i--;
			}

			return lastNode.Value;
		}
	}
}
