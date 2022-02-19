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
    if (miner.FatigueLevel >= miner.FatigueLimit || miner.MoneyInBank >= miner.GoldLimit)
    {
      return true;
    }
    return false;
  }
}