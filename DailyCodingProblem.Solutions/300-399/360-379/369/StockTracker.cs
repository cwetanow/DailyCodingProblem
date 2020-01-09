using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace DailyCodingProblem.Solutions.Problem369
{
	public class StockTracker
	{
		private readonly OrderedBag<double> Ascending = new OrderedBag<double>((a, b) => a.CompareTo(b));
		private readonly OrderedBag<double> Descending = new OrderedBag<double>((a, b) => -a.CompareTo(b));

		private readonly IDictionary<int, double> prices = new Dictionary<int, double>();

		private double Sum { get; set; } = 0;

		public void Add(int datestamp, double price)
		{
			prices.Add(datestamp, price);

			Ascending.Add(price);
			Descending.Add(price);

			Sum += price;
		}

		public void Update(int datestamp, double price)
		{
			Remove(datestamp);
			Add(datestamp, price);
		}

		public void Remove(int datestamp)
		{
			if (!prices.ContainsKey(datestamp))
			{
				return;
			}

			var oldPrice = prices[datestamp];
			prices.Remove(datestamp);

			Ascending.Remove(oldPrice);
			Descending.Remove(oldPrice);

			Sum -= oldPrice;
		}

		public double Min => Ascending.GetFirst();
		public double Max => Descending.GetFirst();
		public double Average => prices.Count > 0 ? Sum / prices.Count : 0;
	}
}
