using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem329
{
	public class Solution
	{
		public static IEnumerable<(string guy, string girl)> PairPeople(int n,
			ICollection<(string name, ICollection<string> preferences)> guyPreferences,
			ICollection<(string name, ICollection<string> preferences)> girlPreferences)
		{
			var result = new List<(string guy, string girl)>();

			while (guyPreferences.Any(p => p.preferences.Any()) && girlPreferences.Any(p => p.preferences.Any()))
			{
				DoWork(guyPreferences, girlPreferences, result, true);
				DoWork(girlPreferences, guyPreferences, result, false);
			}

			return result;
		}

		private static void DoWork(ICollection<(string name, ICollection<string> preferences)> preferences,
			ICollection<(string name, ICollection<string> preferences)> otherPreferencesCollection,
			ICollection<(string guy, string girl)> result, bool guys)
		{
			var next = preferences
				.GroupBy(p => p.preferences.FirstOrDefault())
				.Where(g => g.Count() == 1)
				.Select(g => g.First())
				.ToList();

			foreach (var preference in next)
			{
				var other = preference.preferences.First();

				result.Add(guys ? (preference.name, other) : (other, preference.name));

				preferences.Remove(preference);

				var otherPreferences = otherPreferencesCollection.Single(p => p.name == other);
				otherPreferencesCollection.Remove(otherPreferences);

				foreach (var (_, preferencesCollection) in otherPreferencesCollection)
				{
					preferencesCollection.Remove(preference.name);
				}

				foreach (var (_, preferencesCollection) in preferences)
				{
					preferencesCollection.Remove(other);
				}
			}
		}
	}
}
