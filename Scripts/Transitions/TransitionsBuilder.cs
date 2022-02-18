using System.Collections.Generic;
public class TransitionsBuilder
{
    public Transitions t = new Transitions();
    public void BuildPair(Edge TransitionTo, State NextState)
    {
        //transition->next state
        t.Add(new KeyValuePair<Edge, State>(TransitionTo, NextState));
    }

}