﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateSoldierStandby : SoldierFSMState {
    public StateSoldierStandby(SoldierFSMSystem mFSM) : base(mFSM) { }

    public override void Act(List<ICharacter> enemys) {
        throw new NotImplementedException();
    }

    public override void Reason(List<ICharacter> enemys) {
        if (true) {
            mFSM.PerformTransition(SoldierTransition.SeeEnemy);
        }
    }
}