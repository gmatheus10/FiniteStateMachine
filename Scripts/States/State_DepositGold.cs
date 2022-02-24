using Godot;
public class State_DepositGold : Miner_State_Base
{
  public State_DepositGold(Agent_Miner miner, Node2D building) : base(miner, building) { }

  //Transitions:
  // Deposit -> MineGold
  public override void Execute(float delta)
  {
    if (!IsInBuilding())
    {
      MoveMiner(delta);
    }
    else
    {
      TransitionTo(miner.GoldCarried == 0, "State_MineGold");
      miner.MoneyInBank += miner.GoldCarried;
      miner.GoldCarried = 0;
    }
  }
}