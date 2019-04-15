using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateEnemyAttack : EnemyFSMState {

    public StateEnemyAttack(EnemyFSMSystem mFSM) : base(mFSM) { }

    public override void Act(GameObject player, GameObject npc) {
        throw new NotImplementedException();
    }

    public override void Reason(GameObject player, GameObject npc) {
        if (true) {
            mFSM.PerformTransition(EnemyTransition.SoldierOutOfTheAttackRange);
        }
    }
}