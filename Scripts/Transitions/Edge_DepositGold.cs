using Godot;
public class Edge_DepositGold : Edge
{
    Agent_Miner miner;
    public Edge_DepositGold(Agent Agent)
    {
        miner = (Agent_Miner)Agent;
    }
    public override bool ToTransition()
    {
        if (miner.GoldCarried >= miner.BagLimit)
        {
            return true;
        }
        return false;
    }
}