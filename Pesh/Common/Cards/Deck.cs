namespace Pesh.Common.Cards;

/// <summary>
/// A full deck of cards.
/// </summary>
public class Deck : Pile
{
	public Deck(bool jokers = false)
	{
		var suits = Card.Suits;
		var ranks = Card.Ranks;

		list.EnsureCapacity(suits.Length * ranks.Length + (jokers ? 2 : 0));

		//Add jokers
		if (jokers)
		{
			list.Add(new Card(Suit.RedJoker));
			list.Add(new Card(Suit.BlackJoker));
		}

		//Add regular cards
		foreach (Suit suit in Card.Suits)
		foreach (Rank rank in Card.Ranks)
		{
			list.Add(new Card(suit, rank));
		}
	}

	readonly Random random = new();

	int topCardIndex;

	/// <summary>
	/// Shuffles and <see cref="Reset"/> this deck.
	/// </summary>
	public void Shuffle()
	{
		list.Shuffle(random);
		Reset();
	}

	/// <summary>
	/// Resets this <see cref="Deck"/> to get ready for <see cref="Deal"/> again.
	/// </summary>
	public void Reset() => topCardIndex = 0;

	/// <summary>
	/// Deals out the top <see cref="Card"/> in this <see cref="Deck"/>.
	/// </summary>
	public Card Deal() => list[topCardIndex++];
}