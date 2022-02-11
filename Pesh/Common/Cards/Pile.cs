namespace Pesh.Common.Cards;

/// <summary>
/// A generic collection of cards.
/// </summary>
public class Pile
{
	protected readonly List<Card> list = new();

	public int Count => list.Count;
}