using System.Diagnostics;

namespace Pesh.Common.Cards;

/// <summary>
/// A playing card.
/// </summary>
public readonly struct Card
{
	public Card(Suit suit, Rank rank)
	{
		this.suit = suit;
		this.rank = rank;
	}

	public Card(Suit joker) : this(joker, Rank.Ace) => Debug.Assert(IsJoker);

	public readonly Suit suit;
	public readonly Rank rank;

	public bool IsJoker => suit is Suit.RedJoker or Suit.BlackJoker;

	/// <summary>
	/// The four suits in new deck order (<see cref="Suit.Spades"/> to <see cref="Suit.Hearts"/>).
	/// </summary>
	public static ReadOnlySpan<Suit> Suits => _suits;

	/// <summary>
	/// The thirteen ranks in order from <see cref="Rank.Ace"/> to <see cref="Rank.King"/>.
	/// </summary>
	public static ReadOnlySpan<Rank> Ranks => _ranks;

	/// <summary>
	/// The four <see cref="Suits"/> in new deck order and the red and black jokers.
	/// </summary>
	public static ReadOnlySpan<Suit> SuitAndJokers => _suitsAndJokers;

	static readonly Suit[] _suits = { Suit.Spades, Suit.Diamonds, Suit.Clubs, Suit.Hearts };
	static readonly Rank[] _ranks = { Rank.Ace, Rank.N2, Rank.N3, Rank.N4, Rank.N5, Rank.N6, Rank.N7, Rank.N8, Rank.N9, Rank.N10, Rank.Jack, Rank.Queen, Rank.King };
	static readonly Suit[] _suitsAndJokers = { Suit.Spades, Suit.Diamonds, Suit.Clubs, Suit.Hearts, Suit.RedJoker, Suit.BlackJoker };
}