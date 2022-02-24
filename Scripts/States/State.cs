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
  public bool StateCompleted;

}