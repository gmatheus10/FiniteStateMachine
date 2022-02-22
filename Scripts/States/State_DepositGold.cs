using Godot;
public class State_DepositGold : Miner_State_Base
{
    public State_DepositGold(Agent_Miner miner, Node2D building) : base(miner, building) { }
    public override void OnEnter()
    {
        //GD.Print("GOING TO DEPOSIT");
    }
    public override void Execute(float delta)
    {
        if (!IsInBuilding())
        {
            MoveMiner(delta);
        }
        else
        {
            miner.MoneyInBank += miner.GoldCarried;
            miner.GoldCarried = 0;
            if (miner.GoldCarried == 0) { this.StateCompleted = true; } else { this.StateCompleted = false; }
        }
    }
}