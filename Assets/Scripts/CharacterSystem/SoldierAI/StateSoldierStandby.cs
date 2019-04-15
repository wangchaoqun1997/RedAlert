using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateSoldierStandby : SoldierFSMState {
    public StateSoldierStandby(SoldierFSMSystem mFSM, ICharacter mCharacter) : base(mFSM, mCharacter) { }

    public override void Act(List<ICharacter> enemys) {
        mCharacter.Standby("idel");
    }

    public override void Reason(List<ICharacter> enemys) {

        if (enemys != null && enemys.Count > 0) {
            mFSM.PerformTransition(SoldierTransition.SeeEnemy);
            return;
        }
    }
}