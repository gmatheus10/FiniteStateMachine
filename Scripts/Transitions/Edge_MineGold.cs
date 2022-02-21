using Godot;
class Edge_MineGold : Edge
{
    Agent_Miner miner;
    public Edge_MineGold(Agent agent)
    {
        miner = (Agent_Miner)agent;
    }
    public override bool ToTransition()
    {
        if (miner.GoldCarried < miner.BagLimit)
        {
            if (miner.ThirstLevel < miner.ThirstLimit)
            {
                if (miner.FatigueLevel < miner.FatigueLimit)
                {
                    return true;
                }
            }
        }
        return false;
    }
}