using Godot;
public class Edge_GoHome : Edge
{
    Agent_Miner miner;
    public Edge_GoHome(Agent Agent)
    {
        this.miner = (Agent_Miner)Agent;
    }
    public override bool ToTransition()
    {
        if (miner.FatigueLevel >= miner.FatigueLimit)
        {
            return true;
        }
        if (miner.MoneyInBank >= miner.GoldLimit)
        {
            if (miner.GoldCarried <= 0)
            {
                if (miner.ThirstLevel < miner.ThirstLimit)
                {
                    return true;
                }
            }
        }
        return false;
    }
}