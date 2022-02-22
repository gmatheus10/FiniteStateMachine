using Godot;
using System;
public abstract class State
{

    public virtual void OnEnter() { }
    public virtual void OnExit() { }
    public virtual void Execute(float delta) { }
    public bool StateCompleted;

}