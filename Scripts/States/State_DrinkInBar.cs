using Godot;

public class State_DrinkInBar : Miner_State_Base
{
    public State_DrinkInBar(Agent_Miner miner, Node2D building) : base(miner, building) { }

    public override void Execute(float delta)
    {
        if (!IsInBuilding())
        {
            MoveMiner(delta);
        }
        else
        {
            if (miner.ThirstLevel == 0)
            {
                this.StateCompleted = true;
            }
            else
            {
                this.StateCompleted = false;
                miner.ThirstLevel = 0;
                miner.MoneyInBank /= 2;
            }
        }
    }
}