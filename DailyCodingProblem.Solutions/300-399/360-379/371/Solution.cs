using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem371
{
	public class Solution
	{
		private const char Plus = '+';
		private const char Equal = '=';

		public static IDictionary<string, int> GetVariablesWithValues(ICollection<string> equations)
		{
			var result = new Dictionary<string, int>();

			while (equations.Any())
			{
				var next = equations.FirstOrDefault(eq => CanBeCalculated(eq, result));

				if (string.IsNullOrEmpty(next))
				{
					return null;
				}

				Caclulate(next, result);
				equations.Remove(next);
			}

			return result;
		}

		private static void Caclulate(string equation, IDictionary<string, int> variables)
		{
			equation = variables
			   .Where(v => equation.Contains(v.Key))
			   .Aggregate(equation, (current, variable) => current.Replace(variable.Key, variable.Value.ToString()));

			var sides = equation.Split(Equal)
				.Select(s => s.Trim())
				.ToList();

			// Variable on left side
			if (!int.TryParse(sides[0], out _))
			{
				var variableValue = sides[1]
					.Split(Plus)
					.Select(s => s.Trim())
					.Aggregate(0, (current, next) => current + int.Parse(next));

				variables.Add(sides[0], variableValue);
			}
			// Variable on right side
			else
			{
				var variableValue = sides[1]
					.Split(Plus)
					.Select(s => s.Trim())
					.Where(s => int.TryParse(s, out _))
					.Select(int.Parse)
					.Aggregate(int.Parse(sides[0]), (current, next) => current - next);

				var variable = sides[1]
					.Split(Plus)
					.Select(s => s.Trim())
					.Single(s => !int.TryParse(s, out _));

				variables.Add(variable, variableValue);
			}
		}

		private static bool CanBeCalculated(string equation, IDictionary<string, int> variables)
		{
			var splitted = equation.Split(Plus)
				.SelectMany(s => s.Split(Equal))
				.Select(s => s.Trim())
				.ToList();

			splitted = splitted
				.Where(s => !int.TryParse(s, out _))
				.ToList();

			splitted = splitted
				.Where(s => !variables.ContainsKey(s))
				.ToList();

			if (splitted.Count == 1)
			{
				return true;
			}

			return false;
		}
	}
}
