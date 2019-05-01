using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem152
{
	public class NumberGenerator
	{
		private readonly IList<int> numbers;
		private readonly IList<double> probabilities;

		private readonly Random random = new Random();

		public NumberGenerator(IList<int> numbers, IList<double> probabilities)
		{
			this.numbers = numbers;

			this.probabilities = this.InitializeProbabilities(probabilities);
		}

		public int GenerateNumber()
		{
			var range = random.Next(0, 100) / (double)100;

			for (var i = 0; i < probabilities.Count(); i++)
			{
				if (probabilities[i] > range)
				{
					return numbers[i];
				}
			}

			return 0;
		}

		private IList<double> InitializeProbabilities(IList<double> probs)
		{
			var offset = 0.0;

			for (var i = 0; i < probs.Count(); i++)
			{
				var probability = probs[i];

				probs[i] += offset;

				offset += probability;
			}

			return probs;
		}
	}
}
