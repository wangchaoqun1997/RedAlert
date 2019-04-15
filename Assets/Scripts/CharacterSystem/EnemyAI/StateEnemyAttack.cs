using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateEnemyAttack : EnemyFSMState {

    public StateEnemyAttack(EnemyFSMSystem mFSM) : base(mFSM) { }

    public override void Act(List<ICharacter> soldiers) {
        throw new NotImplementedException();
    }

    public override void Reason(List<ICharacter> soldiers) {
        if (true) {
            mFSM.PerformTransition(EnemyTransition.SoldierOutOfTheAttackRange);
        }
    }
}