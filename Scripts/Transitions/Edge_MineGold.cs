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
      return true;
    }
    return false;
  }
}