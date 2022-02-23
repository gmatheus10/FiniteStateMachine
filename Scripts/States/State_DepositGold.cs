using Godot;
public class State_DepositGold : Miner_State_Base
{
    public State_DepositGold(Agent_Miner miner, Node2D building) : base(miner, building) { }

    public override void Execute(float delta)
    {
        //enter condition and exit condition
        if (!IsInBuilding())
        {
            MoveMiner(delta);
        }
        else
        {
            if (miner.GoldCarried > 0)
            {
                this.StateCompleted = false;
                miner.MoneyInBank += miner.GoldCarried;
                miner.GoldCarried = 0;
            }
            else
            {
                this.StateCompleted = true;
            }
        }
    }
}