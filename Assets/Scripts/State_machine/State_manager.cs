using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_manager : MonoBehaviour
{

    State CurrentState;
    
    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        State nextState = CurrentState?.RunCurrentState();

        if(nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(State state)
    {

    }
}
