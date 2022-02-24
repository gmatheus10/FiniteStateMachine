using Godot;
public class State_GoHome : Miner_State_Base
{
  public State_GoHome(Agent_Miner miner, Node2D building) : base(miner, building) { }

  //Transitions:
  // Home -> MineGold
  public override void Execute(float delta)
  {
    if (!IsInBuilding())
    {
      MoveMiner(delta);
    }
    else
    {
      TransitionTo(miner.FatigueLevel == 0, "State_MineGold");
      if (miner.FatigueLevel > 0)
      {
        miner.FatigueLevel--;
      }
      else
      {
        miner.FatigueLevel = 0;
      }
    }
  }
}