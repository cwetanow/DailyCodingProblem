namespace DailyCodingProblem.Solutions.Problem120
{
	public class Singleton
	{
		private static Singleton FirstInstance;
		private static Singleton SecondInstance;

		private static int Counter = 1;

		protected Singleton(int id)
		{
			Id = id;
		}

		public static void Reset()
		{
			FirstInstance = null;
			SecondInstance = null;
			Counter = 1;
		}

		public static void InitializeSingletons(int evenId, int oddId)
		{
			FirstInstance = new Singleton(evenId);
			SecondInstance = new Singleton(oddId);
		}

		public static Singleton GetInstance()
		{
			return Counter++ % 2 == 0 ? FirstInstance : SecondInstance;
		}

		public int Id { get; set; }
	}
}
