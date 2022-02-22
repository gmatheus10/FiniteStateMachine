using Godot;
class Edge_MineGold : Edge_Miner_Base
{
    public Edge_MineGold(Agent agent) : base(agent) { }

    public override bool ToTransition(State CurrentState)
    {
        if (!CurrentState.StateCompleted)
        {
            return false;
        }
        if (miner.GoldCarried < miner.BagLimit)
        {
            return true;
        }
        return false;
    }
}