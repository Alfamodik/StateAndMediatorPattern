using UnityEngine;

public class GoToWorkState : NPCMovementState
{
    public GoToWorkState(IStateSwitcher stateSwitcher, NPCStateMachineData data, NPC npc) : base(stateSwitcher, data, npc)
    { }

    public override void Update()
    {
        base.Update();

        Vector3 velocity = MovementConfig.WorkPosition - NPC.transform.position;

        if (velocity.magnitude < NPCStateMachineData.Inaccuracy)
            StateSwitcher.SwitchState<WorkState>();
        else
            NPC.CharacterController.Move(MovementConfig.Speed * Time.deltaTime * velocity.normalized);
    }
}
