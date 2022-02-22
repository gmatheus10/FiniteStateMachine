using Godot;
public class Edge_DepositGold : Edge_Miner_Base
{
    public Edge_DepositGold(Agent agent) : base(agent) { }
    public override bool ToTransition(State CurrentState)
    {
        if (!CurrentState.StateCompleted)
        {
            return false;
        }
        if (miner.GoldCarried >= miner.BagLimit)
        {
            return true;
        }
        return false;
    }
}