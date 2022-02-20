using Godot;

public class State_DrinkInBar : Miner_State_Base
{
  public State_DrinkInBar(Agent_Miner miner, Node2D building) : base(miner, building) { }
  public override void OnEnter()
  {
    GD.Print("GOING TO DRINK");
  }
  public override void Execute(float delta)
  {
    if (!IsInBuilding())
    {
      MoveMiner(delta);
    }
    else
    {
      miner.ThirstLevel = 0;
      miner.MoneyInBank -= 15;
    }
  }
}