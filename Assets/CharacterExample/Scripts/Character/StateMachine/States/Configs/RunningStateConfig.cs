using System;
using UnityEngine;

[Serializable]
public class RunningStateConfig
{
    [SerializeField] private WalkingStateConfig _walkingStateConfig;
    [SerializeField] private SlowRunningStateConfig _slowRunningStateConfig;
    [SerializeField] private FastRunningStateConfig _fastRunningStateConfig;

    public WalkingStateConfig WalkingStateConfig => _walkingStateConfig;
    public SlowRunningStateConfig SlowRunningStateConfig => _slowRunningStateConfig;
    public FastRunningStateConfig FastRunningStateConfig => _fastRunningStateConfig;
}
