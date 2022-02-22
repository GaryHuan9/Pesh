namespace Pesh.Common.Cards;

/// <summary>
/// A generic collection of cards.
/// </summary>
public class Pile
{
	readonly List<Card> list = new();

	public int Count => list.Count;

	/// <summary>
	/// Accesses the <see cref="Card"/> at <paramref name="index"/>.
	/// </summary>
	/// <param name="index"></param>
	public Card this[int index]
	{
		get => list[index];
		set => list[index] = value;
	}

	/// <summary>
	/// Adds <paramref name="card"/> to this <see cref="Pile"/>.
	/// </summary>
	/// <param name="card"></param>
	public void Add(Card card) => list.Add(card);

	/// <summary>
	/// Removes <paramref name="card"/> from this <see cref="Pile"/> if it exists.
	/// Returns whether a <see cref="Card"/> has been successfully removed.
	/// </summary>
	public bool Remove(Card card)
	{
		int index = IndexOf(card);
		if (index < 0) return false;

		RemoveAt(index);
		return true;
	}

	/// <summary>
	/// Removes the <see cref="Card"/> at <paramref name="index"/>.
	/// </summary>
	public void RemoveAt(int index) => list.RemoveAt(index);

	/// <summary>
	/// Completely empties this <see cref="Pile"/>.
	/// </summary>
	public void Clear() => list.Clear();

	/// <summary>
	/// Returns the index of <paramref name="card"/> if it is in this <see cref="Pile"/>, a negative number otherwise.
	/// </summary>
	public int IndexOf(Card card) => list.IndexOf(card);

	public List<Card>.Enumerator GetEnumerator() => list.GetEnumerator();
}