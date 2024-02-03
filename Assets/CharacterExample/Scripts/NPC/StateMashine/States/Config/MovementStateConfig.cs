using System;
using UnityEngine;

[Serializable]
public class NPCMovementStateConfig
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _homePosition;
    [SerializeField] private Vector3 _workPosition;

    public float Speed => _speed;
    public Vector3 HomePosition => _homePosition;
    public Vector3 WorkPosition => _workPosition;
}
