using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem346
{
	public class Solution
	{
		public static string GetCheapestItinerary(string source, string destination, int maxConnections, IEnumerable<(string source, string destination, int price)> flights)
		{
			var convertedFlights = flights
				.Select(f => new Flight(f.source, f.destination, f.price))
				.ToList();

			var minPath = GetMinPath(source,
				destination,
				maxConnections,
				0,
				new Path(source, destination),
				convertedFlights, null);

			var path = minPath.Flights
				.Aggregate(source, (currentPath, flight) => $"{currentPath} -> {flight.Destination}");

			return path;
		}

		private static Path GetMinPath(string current, string destination, int maxConnections,
			int currentConnections, Path currentPath, IEnumerable<Flight> flights, Path minPath)
		{
			if (currentConnections > maxConnections)
			{
				return minPath;
			}

			if (current == destination && (minPath == null || currentPath.Price < minPath.Price))
			{
				return currentPath;
			}

			var nextFlights = flights
				.Where(f => f.Source == current && !f.IsVisited);

			foreach (var nextFlight in nextFlights)
			{
				var path = new Path(currentPath, nextFlight);

				minPath = GetMinPath(nextFlight.Destination, destination, maxConnections,
					currentConnections + 1, path, flights, minPath);
			}

			return minPath;
		}

		private class Path
		{
			public Path(Path path, Flight nextFlight)
			{
				Source = path.Source;
				Destination = path.Destination;
				Price = path.Price + nextFlight.Price;

				Flights = path.Flights.Select(f => f).ToList();
				Flights.Add(nextFlight);
			}

			public Path(string source, string destination)
			{
				Source = source;
				Destination = destination;
			}

			public string Source { get; }
			public string Destination { get; }
			public int Price { get; }
			public ICollection<Flight> Flights { get; } = new List<Flight>();
		}

		private class Flight
		{
			public Flight(string source, string destination, int price)
			{
				Source = source;
				Destination = destination;
				Price = price;
			}

			public string Source { get; }
			public string Destination { get; }
			public int Price { get; }
			public bool IsVisited { get; private set; }

			public void Visit()
			{
				this.IsVisited = true;
			}
		}
	}
}
