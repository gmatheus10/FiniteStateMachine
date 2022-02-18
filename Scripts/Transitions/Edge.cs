using Godot;
using System;
public abstract class Edge
{
    public virtual bool ToTransition() { return false; }
}