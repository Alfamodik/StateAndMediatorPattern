using System.Collections.Generic;
using System.Linq;

public class NPCStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;
    private readonly NPCStateMachineData _data;

    public NPCStateMachine(NPC npc)
    {
        _data = new NPCStateMachineData();

        _states = new List<IState>
        {
            new ChillState(this,_data, npc),
            new WorkState(this,_data, npc),
            new GoToWorkState(this,_data, npc),
            new GoToHomeState(this,_data, npc)
        };

        _currentState = _states.First();
        _currentState.Enter();
    }

    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);
        
        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void Update()
    {
        _currentState.HandleInput();
        _currentState.Update();
    }
}
