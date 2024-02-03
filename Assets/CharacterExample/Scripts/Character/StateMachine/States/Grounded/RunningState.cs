public abstract class RunningState : GroundedState
{
    public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
    { }

    public override void Enter()
    {
        base.Enter();

        View.StartRunning();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopRunning();
    }

    public override void Update()
    {
        base.Update();

        if (IsHorizontalInputZero())
            StateSwitcher.SwitchState<IdlingState>();

        else if (FastRunningMode)
            StateSwitcher.SwitchState<FastRunningState>();

        else if (WalkingMode)
            StateSwitcher.SwitchState<WalkingState>();

        else if (IsHorizontalInputZero() == false)
            StateSwitcher.SwitchState<SlowRunningState>();
    }
}
