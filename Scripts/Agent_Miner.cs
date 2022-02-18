using Godot;
using System.Collections.Generic;

public class Agent_Miner : Agent
{
    [Export]
    public int Speed;
    [Export]
    public int ThirstLimit;
    public int ThirstLevel;
    [Export]
    public int FatigueLimit;
    public int FatigueLevel;
    [Export]
    public int BagLimit;
    public int GoldCarried;
    [Export]
    public int GoldLimit;
    public int MoneyInBank;
    public Node2D GoldMine;
    public Vector2 PositionToMove; //make the default equal to the currentPosition
    StateMachine stateMachine;
    /* private void InstantiateTransitions()
    {
        State_MineGold s_mine = new State_MineGold(this);
        Edge_DepositGold e_deposit = new Edge_DepositGold(this);
        InstantiateAndAddPair(e_deposit, s_mine); //Transition to MineGold State
    } */

}
