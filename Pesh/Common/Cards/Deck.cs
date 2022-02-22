using System.Diagnostics;

namespace Pesh.Common.Cards;

/// <summary>
/// A full deck of cards.
/// </summary>
public class Deck
{
	public Deck(bool hasJokers = false)
	{
		this.hasJokers = hasJokers;

		var suits = Card.Suits;
		var ranks = Card.Ranks;

		cards = new Card[suits.Length * ranks.Length + (hasJokers ? 2 : 0)];

		ResetOrder();
	}

	public bool hasJokers;

	readonly Card[] cards;
	readonly Random random = new();

	int topCardIndex;

	/// <summary>
	/// Deals out the top <see cref="Card"/> in this <see cref="Deck"/>.
	/// </summary>
	public Card Deal() => cards[topCardIndex++];

	/// <summary>
	/// Shuffles this <see cref="Deal"/> and invokes <see cref="ResetDeal"/>.
	/// </summary>
	public void Shuffle()
	{
		cards.Shuffle(random);
		ResetDeal();
	}

	/// <summary>
	/// Resets this <see cref="Deck"/> to get ready for <see cref="Deal"/> again.
	/// </summary>
	public void ResetDeal() => topCardIndex = 0;

	/// <summary>
	/// Resets this <see cref="Deck"/> to the new deck order and invokes <see cref="ResetDeal"/>.
	/// </summary>
	public void ResetOrder()
	{
		int index = -1;

		//Add jokers
		if (hasJokers)
		{
			cards[++index] = new Card(Suit.RedJoker);
			cards[++index] = new Card(Suit.BlackJoker);
		}

		//Add regular cards
		foreach (Suit suit in Card.Suits)
		foreach (Rank rank in Card.Ranks)
		{
			cards[++index] = new Card(suit, rank);
		}

		Debug.Assert(index + 1 == cards.Length);

		ResetDeal();
	}
}