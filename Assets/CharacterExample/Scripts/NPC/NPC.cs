using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class NPC : MonoBehaviour
{
    [SerializeField] private NPCConfig _config;

    private NPCInput _input;
    private NPCStateMachine _stateMachine;
    private CharacterController _characterController;

    public CharacterController CharacterController => _characterController;
    public NPCConfig Config => _config;

    public NPCInput Input => _input;

    private void Awake()
    {
        _input = new NPCInput();
        _stateMachine = new NPCStateMachine(this);
        _characterController = GetComponent<CharacterController>();
    }

    private void Update() => _stateMachine.Update();
}
