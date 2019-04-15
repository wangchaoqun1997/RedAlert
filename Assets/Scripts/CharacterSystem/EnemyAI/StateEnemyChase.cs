using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateEnemyChase : EnemyFSMState {
    public StateEnemyChase(EnemyFSMSystem mFSM) : base(mFSM) { }

    public override void Act(List<ICharacter> soldiers) {
        throw new NotImplementedException();
    }

    public override void Reason(List<ICharacter> soldiers) {
        if (true) {
            mFSM.PerformTransition(EnemyTransition.SoldierInTheAttackRange);
        }
    }
}