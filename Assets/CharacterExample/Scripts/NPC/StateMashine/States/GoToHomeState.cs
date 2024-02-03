using UnityEngine;

public class GoToHomeState : NPCMovementState
{
    public GoToHomeState(IStateSwitcher stateSwitcher, NPCStateMachineData data, NPC npc) : base(stateSwitcher, data, npc)
    { }

    public override void Update()
    {
        base.Update();

        Vector3 velocity = MovementConfig.HomePosition - NPC.transform.position;

        if (velocity.magnitude < NPCStateMachineData.Inaccuracy)
            StateSwitcher.SwitchState<ChillState>();
        else
            NPC.CharacterController.Move(MovementConfig.Speed * Time.deltaTime * velocity.normalized);
    }
}
