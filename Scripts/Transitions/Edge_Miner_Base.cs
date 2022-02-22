public abstract class Edge_Miner_Base : Edge
{
    public Agent_Miner miner;

    public Edge_Miner_Base(Agent agent)
    {
        miner = (Agent_Miner)agent;
    }
}