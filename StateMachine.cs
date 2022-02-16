using Godot;
using System.Collections.Generic;
public class StateMachine : Node2D
{
  //Transition is unique, State is not 
  KeyValuePair<Transition, State> TransitionStatePair = new KeyValuePair<Transition, State>();

  class Transitions : List<KeyValuePair<Transition, State>> { } //each state has a transition object assotiated
  Dictionary<State, Transitions> TransitionMap = new Dictionary<State, Transitions>();
  private State currentState;
  public override void _Ready()
  {
  }
  private void Update(float delta)
  {
    //find the set of transitions for the current state
    Transitions it = TransitionMap[currentState];
    //loop through every transition for this state
    foreach (var transPair in it)
    {
      if (transPair.Key.ToTransition())
      {
        SetState(transPair.Value);
        break;
      }
    }
    if (currentState != null)
    {
      currentState.Update(delta);
    }
  }
  private void SetState(State state)
  {

  }
  //  // Called every frame. 'delta' is the elapsed time since the previous frame.
  //  public override void _Process(float delta)
  //  {
  //      
  //  }
}
