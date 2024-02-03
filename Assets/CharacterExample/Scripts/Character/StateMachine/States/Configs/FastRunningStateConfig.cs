using System;
using UnityEngine;

[Serializable]
public class FastRunningStateConfig
{
    [SerializeField, Range(5, 15)] private float _speed;

    public float Speed => _speed;
}
