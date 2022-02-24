using Godot;

public class State_DrinkInBar : Miner_State_Base
{
  public State_DrinkInBar(Agent_Miner miner, Node2D building) : base(miner, building) { }
  //Transitions:
  // Drink -> MineGold
  public override void Execute(float delta)
  {
    if (!IsInBuilding())
    {
      MoveMiner(delta);
    }
    else
    {
      TransitionTo(miner.ThirstLevel == 0, "State_MineGold");
      miner.ThirstLevel = 0;
      miner.MoneyInBank /= 2;
    }
  }
}