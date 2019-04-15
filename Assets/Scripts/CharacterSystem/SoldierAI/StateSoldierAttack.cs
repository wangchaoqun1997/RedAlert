using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateSoldierAttack : SoldierFSMState {

    public StateSoldierAttack(SoldierFSMSystem mFSM) : base(mFSM) { }

    public override void Act(List<ICharacter> enemys) {
        throw new NotImplementedException();
    }

    public override void Reason(List<ICharacter> enemys) {
        if (true) {
            mFSM.PerformTransition(SoldierTransition.EnemyOutOfTheAttackRange);
        }
        if (true) {
            mFSM.PerformTransition(SoldierTransition.DonotSeeEnemy);
        }

    }
}