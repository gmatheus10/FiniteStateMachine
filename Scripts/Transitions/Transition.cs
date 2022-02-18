using Godot;
using System;
public abstract class Transition
{
  public virtual bool ToTransition() { return false; }
}