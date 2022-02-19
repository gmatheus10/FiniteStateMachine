using Godot;
public class State_DepositGold : Miner_State_Base
{
  public State_DepositGold(Agent_Miner miner, Node2D building) : base(miner, building) { }
  public override void Execute(float delta)
  {
    if (!IsInBuilding())
    {
      MoveMiner(delta);
    }
    else
    {
      miner.MoneyInBank = miner.GoldCarried;
      miner.GoldCarried = 0;
    }
  }
}