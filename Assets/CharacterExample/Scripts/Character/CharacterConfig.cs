using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
public class CharacterConfig : ScriptableObject
{
    [SerializeField] private AirbornStateConfig _airbornStateConfig;
    [SerializeField] private RunningStateConfig _runningStateConfig;

    public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
    public RunningStateConfig RunningStateConfig => _runningStateConfig;
}
