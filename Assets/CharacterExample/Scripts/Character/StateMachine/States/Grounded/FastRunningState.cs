using UnityEngine;

public class FastRunningState : RunningState
{
    private readonly FastRunningStateConfig _config;

    public FastRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.RunningStateConfig.FastRunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;
    }
}
