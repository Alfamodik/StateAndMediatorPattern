using UnityEngine;

[CreateAssetMenu(fileName = "NPCConfig", menuName = "Configs/NPCConfig")]
public class NPCConfig : ScriptableObject
{
    [SerializeField] private NPCMovementStateConfig _npcMovementStateConfig;

    public NPCMovementStateConfig NPCMovementStateConfig => _npcMovementStateConfig;
}
