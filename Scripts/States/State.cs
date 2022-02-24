using Godot;
using System;
public abstract class State
{
  public StateMachine StateMachine;
  public virtual void OnEnter() { }
  public virtual void OnExit() { }
  public virtual void Execute(float delta) { }
  public override string ToString()
  {
    return this.GetType().ToString();
  }
  public virtual void TransitionTo(bool Condition, string NextState)
  {
    if (Condition)
    {
      State next = StateMachine.States.Find((State s) => s.ToString() == NextState);
      if (next == null)
      {
        throw new Exception("Next state can't be null");
      }
      else
      {
        StateMachine.ChangeState(next);
      }
    }
  }

}