using Godot;
public class State_GoHome : Miner_State_Base
{
    public State_GoHome(Agent_Miner miner, Node2D building) : base(miner, building) { }
    public override void OnEnter()
    {
        //GD.Print("GOING TO HOME");
    }
    public override void Execute(float delta)
    {
        if (!IsInBuilding())
        {
            MoveMiner(delta);
        }
        else
        {
            if (miner.FatigueLevel > 0)
            {
                miner.FatigueLevel--;
            }
            else
            {
                miner.FatigueLevel = 0;
                if (miner.FatigueLevel == 0) { this.StateCompleted = true; } else { this.StateCompleted = false; }
            }
        }
    }
}