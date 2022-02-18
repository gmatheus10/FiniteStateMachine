public class Edge_GoToBar : Edge
{
    Agent_Miner miner;
    public Edge_GoToBar(Agent Agent)
    {
        miner = (Agent_Miner)Agent;
    }
    public override bool ToTransition()
    {
        if (miner.ThirstLevel >= miner.ThirstLimit)
        {
            return true;
        }
        return false;
    }
}