using Godot;
public class Transitions_DepositGold : Transition
{
  Agent_Miner miner;
  public Transitions_DepositGold(Agent Agent)
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