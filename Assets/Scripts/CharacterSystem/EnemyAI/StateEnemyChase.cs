using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateEnemyChase : EnemyFSMState {
    public StateEnemyChase(EnemyFSMSystem mFSM, ICharacter mCharacter) : base(mFSM, mCharacter) { }

    public override void Act(List<ICharacter> soldiers) {
        if (soldiers != null && soldiers.Count > 0) {
            mCharacter.MoveTo(soldiers[0].position);
        } else {
            ///血点
           // mCharacter.MoveTo(mTargetPosition);
        }
    }

    public override void Reason(List<ICharacter> soldiers) {

        if (soldiers != null && soldiers.Count > 0) {
            float distance = Vector3.Distance(mCharacter.position, soldiers[0].position);
            if (distance <= mCharacter.atkRange) {
                mFSM.PerformTransition(EnemyTransition.SoldierInTheAttackRange);
                return;
            }
        }
    }
}