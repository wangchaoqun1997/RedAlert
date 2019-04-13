using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController  {

    private static StateController instant;
    private StateController() {
    }
    public static StateController Instant {
        get {
            if (instant == null) {
               instant = new StateController();
            }
            return instant;
        }
    }

    private BaseState currentState;

    public void SetState(BaseState newState) {
        DebugMy.Log("SetState",this);
        if (currentState != null) {
            currentState.OnExit();
        }
        currentState = newState;

        currentState.OnPreEnter();

    }

    public void UpdateAction() {
        currentState.UpdateAction();
    }

}
