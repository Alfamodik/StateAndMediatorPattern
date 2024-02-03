using System;
using UnityEngine;

public class Level : MonoBehaviour
{
    public event Action Defeat;
    public event Action Beginning;

    private Player _player;

    public void Initialize(Player player)
    {
        _player = player;
        _player.Health.Death += OnDefeat;
    }

    private void OnDestroy() => _player.Health.Death -= OnDefeat;

    public void StartMe() => Debug.Log("StartLevel");

    public void Restart()
    {
        _player.Reset();
        StartMe();
    }

    public void OnDefeat() => Defeat?.Invoke();
}
