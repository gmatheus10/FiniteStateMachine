using Godot;
using System.Collections.Generic;
public class StateMachine : Node2D
{
  Agent Agent;
  State currentState;
  State lastState;
  State GlobalState;
  KeyValuePair<Transition, State> TransitionStatePair = new KeyValuePair<Transition, State>();
  class Transitions : List<KeyValuePair<Transition, State>> { }
  Transitions transitions = new Transitions();
  Dictionary<State, Transitions> TransitionMap = new Dictionary<State, Transitions>();
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
      foreach (KeyValuePair<Transition, State> transPair in t)
      {
        if (transPair.Key.ToTransition())
        {
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
