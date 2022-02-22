using Godot;
public class Edge_GoToBar : Edge_Miner_Base
{
    public Edge_GoToBar(Agent agent) : base(agent) { }
    public override bool ToTransition(State CurrentState)
    {

        if (!CurrentState.StateCompleted)
        {
            return false;
        }
        if (miner.ThirstLevel >= miner.ThirstLimit)
        {
            return true;
        }
        return false;
    }
}