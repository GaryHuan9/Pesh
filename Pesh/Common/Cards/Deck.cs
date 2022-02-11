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

		//Reverse to new deck order
		list.Reverse(list.Count - ranks.Length * 1, ranks.Length);
		list.Reverse(list.Count - ranks.Length * 2, ranks.Length);
	}

	readonly Random random = new();

	public void Shuffle()
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