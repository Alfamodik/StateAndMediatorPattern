using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private HandleInput _handleInput;
    [SerializeField] private DeffeatPanel _deffeatPanel;
    [SerializeField] private Level _level;

    [SerializeField] private LevelView _scoreView;
    [SerializeField] private HealthBar _healthBar;


    [SerializeField] private int _playerMaxHealth;

    private DeffeatMediator _deffeatMediator;
    private Player _player;

    private void Awake()
    {
        _deffeatMediator = new DeffeatMediator(_deffeatPanel, _level);
        _player = new Player(new Health(_playerMaxHealth), new PlayerLevel(new Score(), 10));

        
        _healthBar.Initialize(_player.Health);
        _scoreView.Initilize(_player.Level);

        _level.Initialize(_player);
        _handleInput.Initialize(new InputForMediator(), _player);
    }
}
