using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateSoldierChase : SoldierFSMState {
    public StateSoldierChase(SoldierFSMSystem mFSM, ICharacter mCharacter) : base(mFSM, mCharacter) { }

    public override void Act(List<ICharacter> enemys) {
        if (enemys != null && enemys.Count > 0) {
            mCharacter.MoveTo(enemys[0].position);
        }
    }

    public override void Reason(List<ICharacter> enemys) {

        if (enemys == null || enemys.Count == 0) {
            mFSM.PerformTransition(SoldierTransition.DonotSeeEnemy);
            return;
        }

        float distance = Vector3.Distance(enemys[0].position, mCharacter.position);
        if (distance <= mCharacter.atkRange) {
            mFSM.PerformTransition(SoldierTransition.EnemyInTheAttackRange);
            return;
        }
    }
}