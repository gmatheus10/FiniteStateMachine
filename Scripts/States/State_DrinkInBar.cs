using Godot;

public class State_DrinkInBar : State
{
    Agent_Miner miner;
    Node2D bar;
    public State_DrinkInBar(Agent miner)
    {
        this.miner = (Agent_Miner)miner;
    }
    public override void OnEnter()
    {
        miner.PositionToMove = bar.GlobalPosition;
    }
    public override void Execute(float delta)
    {
        if (miner.ThirstLevel > 0)
        {
            miner.ThirstLevel--;
        }
        else
        {
            miner.ThirstLevel = 0;
        }
    }
}