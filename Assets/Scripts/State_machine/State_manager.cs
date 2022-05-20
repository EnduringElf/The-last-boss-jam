using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_manager : MonoBehaviour
{

    public State CurrentState;
    
    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        //checks current state is not null with ?
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
