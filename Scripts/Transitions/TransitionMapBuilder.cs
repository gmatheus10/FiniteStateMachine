using System.Collections.Generic;
public class TransitionMapBuilder //builder for enum of TransitionMap: <State, Transitions>
{
    //for each state there will be a transitionmap builder?
    TransitionsBuilder transitionsBuilder = new TransitionsBuilder();
    Dictionary<State, Transitions> TransitionMap = new Dictionary<State, Transitions>();


}