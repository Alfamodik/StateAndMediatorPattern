using UnityEngine;

public class SlowRunningState : RunningState
{
    private readonly SlowRunningStateConfig _config;

    public SlowRunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.RunningStateConfig.SlowRunningStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;
    }
}
