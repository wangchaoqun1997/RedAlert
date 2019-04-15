using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateChase :FSMState{
    public StateChase(FSMSystem mFSM) : base(mFSM) { }

    public override void Act(GameObject player, GameObject npc) {
        throw new NotImplementedException();
    }

    public override void Reason(GameObject player, GameObject npc) {
        if (true) {
            mFSM.PerformTransition(Transition.EnemyInTheAttackRange);
        }
        if (true) {
            mFSM.PerformTransition(Transition.DonotSeeEnemy);
        }

    }
}