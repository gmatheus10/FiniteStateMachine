using Godot;
using System.Collections.Generic;

public class Agent_Miner : Agent
{
  [Export] public int Speed;
  [Export] public int ThirstLimit;
  [Export] public int FatigueLimit;
  [Export] public int BagLimit;
  [Export] public int GoldLimit;
  public int ThirstLevel;
  public int FatigueLevel;
  public int GoldCarried;
  public int MoneyInBank;
  public Node2D GoldMine;
  public Vector2 PositionToMove; //make the default equal to the currentPosition
  State baseState;
  StateMachine stateMachine;
  public override void _Ready()
  {
    InstantiateStateMachine();
  }
  private void InstantiateStateMachine()
  {
    List<State> states = InstantiateStates();
    stateMachine = new StateMachine(this, states, states[0]);
    stateMachine.Name = "Miner_StateMachine";
    AddChild(stateMachine);
  }
  private List<State> InstantiateStates()
  {
    Node2D mine = GetNode<Node2D>("../GoldMine");
    Node2D bank = GetNode<Node2D>("../Bank");
    Node2D home = GetNode<Node2D>("../Home");
    Node2D bar = GetNode<Node2D>("../Bar");
    State_DepositGold s_deposit = new State_DepositGold(this, bank);
    State_DrinkInBar s_drink = new State_DrinkInBar(this, bar);
    State_GoHome s_home = new State_GoHome(this, home);
    State_MineGold s_mine = new State_MineGold(this, mine);
    List<State> states = new List<State>() { s_mine, s_deposit, s_drink, s_home };
    return states;
  }

}
