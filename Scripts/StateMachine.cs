using Godot;
using System.Collections.Generic;
public class StateMachine : Node2D
{
  Agent Agent;
  State currentState;
  State lastState;
  State GlobalState;
  Transitions Transitions;
  Dictionary<State, Transitions> TransitionMap; // the state here is the current
  public StateMachine(Agent Agent, Dictionary<State, Transitions> TransitionMap, State GlobalState)
  {
    this.Agent = Agent;
    this.TransitionMap = TransitionMap;
    this.GlobalState = GlobalState;
  }
  public override void _Process(float delta)
  {
    Update(delta);
  }
  public void Update(float delta)
  {
    ExecuteState(GlobalState, delta);
    CheckTransition();
    ExecuteState(currentState, delta);
  }
  private void CheckTransition()
  {
    if (currentState != null)
    {
      Transitions t = TransitionMap[currentState];
      foreach (KeyValuePair<Edge, State> transPair in t)
      {
        if (transPair.Key.ToTransition())
        {
          //it transition to the first state that returns true. So it has a priority of transitions.
          ChangeState(transPair.Value);
          break;
        }
      }
    }
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
