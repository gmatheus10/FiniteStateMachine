using Godot;
using System.Collections.Generic;
public class StateMachine : Node2D
{
    Agent Agent;
    State currentState;
    State lastState;
    State GlobalState;
    public void Update(float delta)
    {
        ExecuteState(GlobalState, delta);
        ExecuteState(currentState, delta);
    }
    private void ExecuteState(State state, float delta)
    {
        if (state != null)
        {
            state.Execute(delta);
        }
    }
    public void ChangeState(State state)
    {
        lastState = currentState;
        currentState.OnExit();
        currentState = state;
        currentState.OnEnter();
    }
    public void RevertState()
    {
        ChangeState(lastState);
    }
}
