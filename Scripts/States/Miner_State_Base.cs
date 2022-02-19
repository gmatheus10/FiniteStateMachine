using Godot;
public abstract class Miner_State_Base : State
{
  public Agent_Miner miner;
  public Node2D building;
  public Miner_State_Base(Agent_Miner miner, Node2D building)
  {
    this.miner = miner;
    this.building = building;
  }
  public bool IsInBuilding()
  {
    if (miner.GlobalPosition.DistanceTo(miner.PositionToMove) > 0)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public void MoveMiner(float delta)
  {
    if (building != null)
    {
      miner.GlobalPosition.MoveToward(building.GlobalPosition, delta * miner.Speed);
    }
  }
}