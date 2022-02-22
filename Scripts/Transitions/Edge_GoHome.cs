using Godot;
public class Edge_GoHome : Edge_Miner_Base
{
    public Edge_GoHome(Agent agent) : base(agent) { }
    public override bool ToTransition(State CurrentState)
    {

        if (!CurrentState.StateCompleted)
        {
            return false;
        }
        if (miner.FatigueLevel >= miner.FatigueLimit)
        {
            return true;
        }
        return false;
    }
}