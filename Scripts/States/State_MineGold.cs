using Godot;
class State_MineGold : State
{
    Agent_Miner miner;
    public State_MineGold(Agent agent)
    {
        miner = (Agent_Miner)agent;
    }
    public override void Execute(float delta)
    {
        miner.GoldCarried++;
    }
}