using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCodingProblem.Solutions.Problem313
{
	public class Solution
	{
		public static int? GetMinimumMovesToTargetState(string targetState, IEnumerable<string> deadEnds)
		{
			return GetMinimumMovesToTargetState(LockState.Create(targetState), new LockState(0, 0, 0), deadEnds.Select(LockState.Create), int.MaxValue, 0, null);
		}

		private static int? GetMinimumMovesToTargetState(LockState target, LockState current, IEnumerable<LockState> deadEnds, int currentMin, int currentMoves, LockState previousState)
		{
			if (deadEnds.Any(s => s == current))
			{
				return null;
			}

			if (current == target)
			{
				return Math.Min(currentMin, currentMoves);
			}

			var nextMoves = new List<LockState>
			{
				current.MoveFirstClockwise(),
				current.MoveSecondClockwise(),
				current.MoveThirdClockwise(),
				current.MoveFirstCounterClockwise(),
				current.MoveSecondCounterClockwise(),
				current.MoveThirdCounterClockwise(),
			};

			foreach (var nextMove in nextMoves)
			{
				if (nextMove == previousState)
				{
					continue;
				}

				currentMin = Math.Min(currentMin,
					GetMinimumMovesToTargetState(target, nextMove, deadEnds, currentMin, currentMoves + 1, current) ?? int.MaxValue);
			}

			return currentMin;
		}

		private class LockState
		{
			public LockState(int first, int second, int third)
			{
				First = first;
				Second = second;
				Third = third;
			}

			public int First { get; }
			public int Second { get; }
			public int Third { get; }

			public static bool operator ==(LockState left, LockState right) =>
				left != null &&
				right != null &&
				left.First == right.First &&
				left.Second == right.Second &&
				left.Third == right.Third;

			public static bool operator !=(LockState left, LockState right) => !(left == right);

			public static LockState Create(string state)
			{
				return new LockState(int.Parse(state[0].ToString()),
					int.Parse(state[3].ToString()),
					int.Parse(state[2].ToString()));
			}

			public LockState MoveFirstClockwise() => new LockState(First + 1, Second, Third);
			public LockState MoveSecondClockwise() => new LockState(First, Second + 1, Third);
			public LockState MoveThirdClockwise() => new LockState(First, Second, Third + 1);

			public LockState MoveFirstCounterClockwise() => new LockState(First - 1, Second, Third);
			public LockState MoveSecondCounterClockwise() => new LockState(First, Second - 1, Third);
			public LockState MoveThirdCounterClockwise() => new LockState(First, Second, Third - 1);
		}
	}
}
