namespace Pesh.Common;

public static class Utility
{
	/// <summary>
	/// Shuffles <paramref name="list"/> using <paramref name="random"/>.
	/// </summary>
	public static void Shuffle<T>(this IList<T> list, Random random)
	{
		for (int i = list.Count - 1; i > 0; i--)
		{
			int other = random.Next(i + 1);

			//Swap
			var storage = list[other];
			list[other] = list[i];
			list[i] = storage;
		}
	}
}