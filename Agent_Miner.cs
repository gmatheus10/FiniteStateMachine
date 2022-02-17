using Godot;
using System;

public class Agent_Miner : Agent
{
    public int ThirstLevel;
    public int FatigueLevel;
    public int GoldCarried;
    public int MoneyInBank;

    StateMachine stateMachine;
    public delegate void ExitMine();
    public event ExitMine OnBagFull;
    public delegate void GoToBar();
    public event GoToBar OnThirstHigh;
}
