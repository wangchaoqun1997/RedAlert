using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateAttack : FSMState {

    public StateAttack(FSMSystem mFSM) : base(mFSM) { }

    /// <summary>
    /// 本状态的Act
    /// </summary>
    /// <param name="player"></param>
    /// <param name="npc"></param>
    public override void Act(GameObject player, GameObject npc) {
        throw new NotImplementedException();
    }

    public override void Reason(GameObject player, GameObject npc) {
        if (true) {
            mFSM.PerformTransition(Transition.EnemyOutOfTheAttackRange);
        }
        if (true) {
            mFSM.PerformTransition(Transition.DonotSeeEnemy);
        }

    }
}