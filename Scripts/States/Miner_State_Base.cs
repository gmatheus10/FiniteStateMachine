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
    public override void OnEnter()
    {
        GD.Print($"Gold: {miner.GoldCarried} - Bank: {miner.MoneyInBank} - Thirst: {miner.ThirstLevel} - Fatigue: {miner.FatigueLevel}");
    }
    public bool IsInBuilding()
    {
        if (miner.Position.DistanceTo(building.Position) <= 0)
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
            miner.Position = miner.Position.MoveToward(building.Position, delta * miner.Speed);
            if (miner.Position.DistanceTo(building.Position) <= 0)
            {
                miner.Position = building.Position;
            }
        }
    }
}