﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public abstract class FSMState {
    protected StateID stateID;
    public StateID ID { get { return stateID; } }
    protected FSMSystem mFSM;

    /// <summary>
    /// 本状态可以切换到的状态集合及条件集合
    /// </summary>
    protected Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();

    protected FSMState(FSMSystem mFSM) {
        this.mFSM = mFSM;
    }



    public void AddTransition(Transition trans, StateID id) {
        // Check if anyone of the args is invalid
        if (trans == Transition.NullTransition) {
            Debug.LogError("FSMState ERROR: NullTransition is not allowed for a real transition");
            return;
        }

        if (id == StateID.NullStateID) {
            Debug.LogError("FSMState ERROR: NullStateID is not allowed for a real ID");
            return;
        }

        // Since this is a Deterministic FSM,
        //   check if the current transition was already inside the map
        if (map.ContainsKey(trans)) {
            Debug.LogError("FSMState ERROR: State " + stateID.ToString() + " already has transition " + trans.ToString() +
                           "Impossible to assign to another state");
            return;
        }

        map.Add(trans, id);
    }



    public void DeleteTransition(Transition trans) {
        // Check for NullTransition
        if (trans == Transition.NullTransition) {
            Debug.LogError("FSMState ERROR: NullTransition is not allowed");
            return;
        }

        // Check if the pair is inside the map before deleting
        if (map.ContainsKey(trans)) {
            map.Remove(trans);
            return;
        }
        Debug.LogError("FSMState ERROR: Transition " + trans.ToString() + " passed to " + stateID.ToString() +
                       " was not on the state's transition list");
    }


    public StateID GetOutputState(Transition trans) {
        // Check if the map has this transition
        if (map.ContainsKey(trans)) {
            return map[trans];
        }
        return StateID.NullStateID;
    }


    /// <summary>
    /// This method is used to set up the State condition before entering it.
    /// It is called automatically by the FSMSystem class before assigning it
    /// to the current state.
    /// </summary>
    public virtual void DoBeforeEntering() { }

    /// <summary>
    /// This method is used to make anything necessary, as reseting variables
    /// before the FSMSystem changes to another one. It is called automatically
    /// by the FSMSystem before changing to a new state.
    /// </summary>
    public virtual void DoBeforeLeaving() { }

    /// <summary>
    /// This method decides if the state should transition to another on its list
    /// NPC is a reference to the object that is controlled by this class
    /// </summary>
    public abstract void Reason(GameObject player, GameObject npc);

    /// <summary>
    /// This method controls the behavior of the NPC in the game World.
    /// Every action, movement or communication the NPC does should be placed here
    /// NPC is a reference to the object that is controlled by this class
    /// </summary>
    public abstract void Act(GameObject player, GameObject npc);

}