using UnityEngine;

public class WorkState : NPCNoMovementState
{
    public WorkState(IStateSwitcher stateSwitcher, NPCStateMachineData data, NPC npc) : base(stateSwitcher, data, npc)
    { }

    public override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Space))
            StateSwitcher.SwitchState<GoToHomeState>();
    }
}
