using Godot;
public class State_GoHome : State
{
    Agent_Miner miner;
    Node2D home;
    public State_GoHome(Agent Agent)
    {
        this.miner = (Agent_Miner)Agent;
    }
    public override void OnEnter()
    {
        miner.PositionToMove = home.GlobalPosition;
    }
    public override void Execute(float delta)
    {
        if (miner.FatigueLevel > 0)
        {
            miner.FatigueLevel--;
        }
        else
        {
            miner.FatigueLevel = 0;
        }
    }
}