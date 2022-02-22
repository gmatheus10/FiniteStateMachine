using Godot;
class State_MineGold : Miner_State_Base
{
    public State_MineGold(Agent_Miner miner, Node2D building) : base(miner, building) { }
    public override void OnEnter()
    {
        //GD.Print("GOING TO MINE");
    }

    public override void Execute(float delta)
    {
        if (!IsInBuilding())
        {
            MoveMiner(delta);
        }
        else
        {
            miner.GoldCarried++;
            miner.ThirstLevel++;
            miner.FatigueLevel++;
            if (miner.GoldCarried >= miner.BagLimit) { this.StateCompleted = true; } else { this.StateCompleted = false; }
        }
    }
}