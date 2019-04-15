using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateStandby:FSMState {
    public StateStandby(FSMSystem mFSM) : base(mFSM) { }

    public override void Act(GameObject player, GameObject npc) {
        throw new NotImplementedException();
    }

    public override void Reason(GameObject player, GameObject npc) {
        if (true) {
            mFSM.PerformTransition(Transition.SeeEnemy);
        }
    }
}