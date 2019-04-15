using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class EnemyFSMSystem {
    private List<EnemyFSMState> states;

    private EnemyStateID currentStateID;
    public EnemyStateID CurrentStateID { get { return currentStateID; } }
    private EnemyFSMState currentState;
    public EnemyFSMState CurrentState { get { return currentState; } }

    public EnemyFSMSystem() {
        states = new List<EnemyFSMState>();
    }


    /// <summary>
    /// This method places new states inside the FSM,
    /// or prints an ERROR message if the state was already inside the List.
    /// First state added is also the initial state.
    /// </summary>
    public void AddState(EnemyFSMState s) {
        // Check for Null reference before deleting
        if (s == null) {
            Debug.LogError("EnemyFSM ERROR: Null reference is not allowed");
        }

        // First State inserted is also the Initial state,
        //   the state the machine is in when the simulation begins
        if (states.Count == 0) {
            states.Add(s);
            currentState = s;
            currentStateID = s.ID;
            return;
        }

        // Add the state to the List if it's not inside it
        foreach (EnemyFSMState state in states) {
            if (state.ID == s.ID) {
                Debug.LogError("EnemyFSM ERROR: Impossible to add state " + s.ID.ToString() +
                               " because state has already been added");
                return;
            }
        }
        states.Add(s);
    }


    /// <summary>
    /// This method delete a state from the FSM List if it exists, 
    ///   or prints an ERROR message if the state was not on the List.
    /// </summary>
    public void DeleteState(EnemyStateID id) {
        // Check for NullState before deleting
        if (id == EnemyStateID.NullStateID) {
            Debug.LogError("EnemyFSM ERROR: NullStateID is not allowed for a real state");
            return;
        }

        // Search the List and delete the state if it's inside it
        foreach (EnemyFSMState state in states) {
            if (state.ID == id) {
                states.Remove(state);
                return;
            }
        }
        Debug.LogError("EnemyFSM ERROR: Impossible to delete state " + id.ToString() +
                       ". It was not on the list of states");
    }


    /// <summary>
    /// This method tries to change the state the FSM is in based on
    /// the current state and the transition passed. If current state
    ///  doesn't have a target state for the transition passed, 
    /// an ERROR message is printed.
    /// </summary>
    public void PerformTransition(EnemyTransition trans) {
        // Check for NullTransition before changing the current state
        if (trans == EnemyTransition.NullTransition) {
            Debug.LogError("EnemyFSM ERROR: NullTransition is not allowed for a real transition");
            return;
        }

        // Check if the currentState has the transition passed as argument
        EnemyStateID id = currentState.GetOutputState(trans);
        if (id == EnemyStateID.NullStateID) {
            Debug.LogError("EnemyFSM ERROR: State " + currentStateID.ToString() + " does not have a target state " +
                           " for transition " + trans.ToString());
            return;
        }

        // Update the currentStateID and currentState		
        currentStateID = id;
        foreach (EnemyFSMState state in states) {
            if (state.ID == currentStateID) {
                // Do the post processing of the state before setting the new one
                currentState.DoBeforeLeaving();

                currentState = state;

                // Reset the state to its desired condition before it can reason or act
                currentState.DoBeforeEntering();
                break;
            }
        }

    } // PerformTransition()

}