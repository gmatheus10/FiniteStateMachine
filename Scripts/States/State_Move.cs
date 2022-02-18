using Godot;
public class State_Move : State
{
    Agent_Miner miner;
    public State_Move(Agent agent)
    {
        miner = (Agent_Miner)agent;
    }
    public override void Execute(float delta)
    {
        miner.GlobalPosition.MoveToward(miner.PositionToMove, delta * miner.Speed);
    }
}