using System;
using Godot;

public abstract class Transition
{
    public virtual bool ToTransition()
    {
        //returns a Boolean for whether or not the transition should occur.
        return false;
    }
}