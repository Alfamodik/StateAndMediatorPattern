using UnityEngine;

public abstract class NPCMovementState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly NPCStateMachineData Data;
    protected readonly NPC NPC;
    
    public NPCMovementState(IStateSwitcher stateSwitcher, NPCStateMachineData data, NPC npc)
    {
        StateSwitcher = stateSwitcher;
        Data = data;
        NPC = npc;
    }

    public NPCMovementStateConfig MovementConfig => NPC.Config.NPCMovementStateConfig;

    public virtual void Enter()
    {
        Debug.Log(GetType());
    }

    public virtual void Exit() { }

    public virtual void HandleInput() => Data.GoNext = NPC.Input.Movement.GoNext.inProgress;

    public virtual void Update() { }
}
