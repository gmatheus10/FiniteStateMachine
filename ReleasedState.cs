using System;
using Godot;
public class ReleasedState : State
{
    public override void Update(float delta)
    {
        GD.Print("Released");
    }
}