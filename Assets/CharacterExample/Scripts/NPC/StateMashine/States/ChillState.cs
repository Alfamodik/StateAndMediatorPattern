using UnityEngine;

public class ChillState : NPCNoMovementState
{
    public ChillState(IStateSwitcher stateSwitcher, NPCStateMachineData data, NPC npc) : base(stateSwitcher, data, npc)
    { }

    public override void Update()
    {
        base.Update();

        if (Input.GetKeyDown(KeyCode.Space))
            StateSwitcher.SwitchState<GoToWorkState>();
    }
}
