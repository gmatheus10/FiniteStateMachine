using Godot;
using System;

public class Agent_Miner : Agent
{
  public int ThirstLevel;
  public int FatigueLevel;
  [Export]
  public int BagLimit;
  public int GoldCarried;
  [Export]
  public int GoldLimit;
  public int MoneyInBank;
  public Node2D GoldMine;
  StateMachine stateMachine;
}
