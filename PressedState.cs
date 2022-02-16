using System;
using Godot;
public class PresedState : State
{
    public override void Update(float delta)
    {
        GD.Print("Pressed");
    }
}