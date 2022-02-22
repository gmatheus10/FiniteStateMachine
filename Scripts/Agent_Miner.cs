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
        Node2D mine = GetNode<Node2D>("../GoldMine");
        Node2D bank = GetNode<Node2D>("../Bank");
        Node2D home = GetNode<Node2D>("../Home");
        Node2D bar = GetNode<Node2D>("../Bar");

        stateMachine = new StateMachine(this, InstantiateMap(mine, bank, home, bar), baseState);
        stateMachine.Name = "Miner_StateMachine";
        AddChild(stateMachine);
    }
    private Dictionary<State, Transitions> InstantiateMap(Node2D Mine, Node2D Bank, Node2D Home, Node2D Bar)
    {
        Dictionary<State, Transitions> TransitionMap = new Dictionary<State, Transitions>();

        State_MineGold s_mine = new State_MineGold(this, Mine);
        State_DepositGold s_deposit = new State_DepositGold(this, Bank);
        State_DrinkInBar s_drink = new State_DrinkInBar(this, Bar);
        State_GoHome s_home = new State_GoHome(this, Home);

        Edge_MineGold e_mine = new Edge_MineGold(this);
        Edge_DepositGold e_deposit = new Edge_DepositGold(this);
        Edge_GoToBar e_drink = new Edge_GoToBar(this);
        Edge_GoHome e_home = new Edge_GoHome(this);
        ///////////////////////////////////////////////////////////////////////////

        Transitions T_mine = new Transitions();

        //Mine->Deposit:
        TransitionsBuilder.BuildPair(ref T_mine, e_deposit, s_deposit);
        //Mine->Drink:
        TransitionsBuilder.BuildPair(ref T_mine, e_drink, s_drink);

        TransitionMap.Add(s_mine, T_mine);
        ///////////////////////////////////////////////////////////////////////////

        Transitions T_drink = new Transitions();

        //Drink->Mine:
        TransitionsBuilder.BuildPair(ref T_drink, e_mine, s_mine);
        TransitionsBuilder.BuildPair(ref T_drink, e_deposit, s_deposit);

        TransitionMap.Add(s_drink, T_drink);
        ///////////////////////////////////////////////////////////////////////////

        Transitions T_home = new Transitions();

        //Home->Mine:
        TransitionsBuilder.BuildPair(ref T_home, e_mine, s_mine);
        TransitionsBuilder.BuildPair(ref T_home, e_deposit, s_deposit);

        TransitionMap.Add(s_home, T_home);
        ///////////////////////////////////////////////////////////////////////////

        Transitions T_deposit = new Transitions();

        //Deposit->Mine:
        TransitionsBuilder.BuildPair(ref T_deposit, e_mine, s_mine);
        //Deposit->Home:
        TransitionsBuilder.BuildPair(ref T_deposit, e_home, s_home);
        //Deposit->Drink:
        TransitionsBuilder.BuildPair(ref T_deposit, e_drink, s_drink);

        TransitionMap.Add(s_deposit, T_deposit);
        ///////////////////////////////////////////////////////////////////////////

        baseState = s_mine;
        return TransitionMap;
    }

}
