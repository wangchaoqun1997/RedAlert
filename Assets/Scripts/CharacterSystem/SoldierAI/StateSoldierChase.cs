using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateSoldierChase : SoldierFSMState {
    public StateSoldierChase(SoldierFSMSystem mFSM) : base(mFSM) { }

    public override void Act(List<ICharacter> enemys) {
        throw new NotImplementedException();
    }

    public override void Reason(List<ICharacter> enemys) {
        if (true) {
            mFSM.PerformTransition(SoldierTransition.EnemyInTheAttackRange);
        }
        if (true) {
            mFSM.PerformTransition(SoldierTransition.DonotSeeEnemy);
        }
    }
}