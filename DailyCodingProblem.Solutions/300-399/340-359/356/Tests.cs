using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.Solutions.Problem356
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Test_ShouldReturnCorrectly()
		{
			var arrays = new List<int[]>
			{
				new int[3],
				new int[2],
			};

			var queue = new FixedLengthArraysQueue<int>(arrays);

			var items = Enumerable.Range(0, 4).ToList();

			foreach (var item in items)
			{
				queue.Enqueue(item);
			}

			queue.Size.Should().Be(items.Count);

			var result = items
				.Select(_ => queue.Dequeue())
				.ToList();

			result.Should().BeEquivalentTo(items);
		}
	}
}
