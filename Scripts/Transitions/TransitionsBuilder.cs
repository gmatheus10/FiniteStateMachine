using System.Collections.Generic;
public static class TransitionsBuilder
{
  public static void BuildPair(ref Transitions transitions, Edge TransitionTo, State NextState)
  {
    transitions.Add(new KeyValuePair<Edge, State>(TransitionTo, NextState));
  }
}