public class Player
{
    private Health _health;
    private PlayerLevel _level;

    public Player(Health health, PlayerLevel level)
    {
        _health = health;
        _level = level;
    }
    public Health Health => _health;
    public PlayerLevel Level => _level;

    public void Reset()
    {
        _health.Reset();
        _level.Reset();
    }
}
