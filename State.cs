using Godot;
using System;
public abstract class State
{
    Node2D Agent;
    protected virtual void OnEnter() { }
    protected virtual void OnExit() { }
    public virtual void Update(float delta) { }


}