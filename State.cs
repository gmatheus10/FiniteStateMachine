using Godot;
using System;
public abstract class State
{
    //notify when a transition should occur
    Agent Agent;
    public virtual void OnEnter() { }
    public virtual void OnExit() { }
    public virtual void Execute(float delta) { }


}