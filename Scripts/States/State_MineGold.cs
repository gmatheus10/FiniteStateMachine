using Godot;
class State_MineGold : Miner_State_Base
{
  public State_MineGold(Agent_Miner miner, Node2D building) : base(miner, building) { }

  //Transitions:
  // Mine -> Deposit
  // Mine -> Drink
  // Mine -> Home
  public override void Execute(float delta)
  {
    if (!IsInBuilding())
    {
      MoveMiner(delta);
    }
    else
    {
      TransitionTo(miner.GoldCarried >= miner.BagLimit, "State_DepositGold");
      TransitionTo(miner.ThirstLevel >= miner.ThirstLimit, "State_DrinkInBar");
      TransitionTo(miner.FatigueLevel >= miner.FatigueLimit, "State_GoHome");
      miner.GoldCarried++;
      miner.ThirstLevel++;
      miner.FatigueLevel++;
    }
  }
}