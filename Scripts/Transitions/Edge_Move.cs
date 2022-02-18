using Godot;
public class Edge_Move : Edge
{
    Agent_Miner miner;
    float leeWay;
    public Edge_Move(Agent Agent)
    {
        miner = (Agent_Miner)Agent;
    }
    public override bool ToTransition()
    {
        if (miner.GlobalPosition.DistanceTo(miner.PositionToMove) > 0 + leeWay)
        {
            return true;
        }
        return false;
    }
}