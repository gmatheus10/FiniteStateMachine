using Godot;
class State_MineGold : State
{
  StateMachine stateMachine;
  Vector2 MinePosition;
  Agent_Miner miner;
  Node2D GoldMine;
  public State_MineGold(Agent agent)
  {
    miner = (Agent_Miner)agent;
    this.GoldMine = miner.GoldMine;
  }
  public override void Execute(float delta)
  {
    if (miner.GlobalPosition != GoldMine.GlobalPosition)
    {
      //move to the gold mine
    }
    miner.GoldCarried++;

  }
}