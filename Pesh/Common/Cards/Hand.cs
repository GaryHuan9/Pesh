using System.Diagnostics;

namespace Pesh.Common.Cards;

/// <summary>
/// A collection of cards in a <see cref="Player"/>'s hand.
/// </summary>
public class Hand : Pile
{
	/// <summary>
	/// Receives <paramref name="card"/> into this <see cref="Hand"/>.
	/// </summary>
	public void Receive(Card card)
	{
		Debug.Assert(!list.Contains(card));
		list.Add(card);
	}

	/// <summary>
	/// Takes out a <see cref="Card"/> at <paramref name="index"/>.
	/// </summary>
	public Card TakeOut(int index)
	{
		Card card = list[index];
		list.RemoveAt(index);

		return card;
	}

	/// <summary>
	/// Completely empties this <see cref="Hand"/>.
	/// </summary>
	public void Clear() => list.Clear();
}