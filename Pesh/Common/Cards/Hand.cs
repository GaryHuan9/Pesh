using System.Diagnostics;

namespace Pesh.Common.Cards;

/// <summary>
/// A collection of cards in a <see cref="Player"/>'s hand.
/// </summary>
public class Hand : Pile
{
	public void Receive(Card card)
	{
		Debug.Assert(!list.Contains(card));
		list.Add(card);
	}

	public Card TakeOut(int index)
	{
		Card card = list[index];
		list.RemoveAt(index);

		return card;
	}

	public void Clear() => list.Clear();
}