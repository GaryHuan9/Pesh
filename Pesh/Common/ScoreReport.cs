namespace Pesh.Common;

/// <summary>
/// Scores reported from a <see cref="Game{T}"/> session for a collection of players.
/// </summary>
public class ScoreReport
{
	public ScoreReport(int count, bool highestWins = true)
	{
		this.highestWins = highestWins;
		array = new int[count];
	}

	public readonly bool highestWins;

	readonly int[] array;

	/// <summary>
	/// Reference accesses the individual scores of this <see cref="ScoreReport"/> at <paramref name="index"/>.
	/// </summary>
	public ref int this[int index] => ref array[index];

	/// <summary>
	/// Fills <paramref name="winners"/> with the indices of the <see cref="Player"/>s that are currently winning.
	/// Returns the number of <see cref="Player"/> indices filled, which is equals to the number of current winners.
	/// </summary>
	public int FillWinners(Span<int> winners) => throw new NotImplementedException();

	/// <summary>
	/// Fills <paramref name="placements"/> with the current placement of each <see cref="Player"/> at their index.
	/// The placements go from 0 (currently winning) to a nonnegative number (last place), and allows for ties.
	/// Returns the number of elements filled in <paramref name="placements"/>.
	/// </summary>
	public int FillPlacements(Span<int> placements) => throw new NotImplementedException();

	/// <summary>
	/// Sets the score for every <see cref="Player"/> to <paramref name="value"/>.
	/// </summary>
	public void Fill(int value = 0) => Array.Fill(array, value);
}