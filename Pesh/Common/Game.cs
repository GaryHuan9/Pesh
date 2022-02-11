namespace Pesh.Common;

/// <summary>
/// A generic game that can be played.
/// </summary>
public abstract class Game<T> where T : Player
{
	public Game(int maxPlayer = int.MaxValue) => this.maxPlayer = maxPlayer;

	public readonly int maxPlayer;

	readonly Random random = new();
	readonly List<T> players = new();

	public int PlayerCount => players.Count;

	/// <summary>
	/// Returns the player sitting at <paramref name="index"/>.
	/// </summary>
	public T this[int index] => players[index];

	/// <summary>
	/// Adds <paramref name="player"/> to this <see cref="Game{T}"/>.
	/// </summary>
	public void Add(T player)
	{
		if (PlayerCount < maxPlayer) players.Add(player);
		else throw new Exception($"Cannot add {player} because {this} is full!");
	}

	/// <summary>
	/// Shuffles the seats of all the <see cref="players"/> in this <see cref="Game{T}"/>.
	/// </summary>
	public void ShuffleSeats() => players.Shuffle(random);

	/// <summary>
	/// Initializes this <see cref="Game{T}"/> to be ready for a new 'session'.
	/// </summary>
	public abstract void Initialize();

	/// <summary>
	/// Simulates this <see cref="Game{T}"/> for one 'round'. Returns true if this game 'session' has concluded, false otherwise.
	/// </summary>
	public abstract bool Simulate();
}