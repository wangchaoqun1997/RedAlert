﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateSoldierStandby : SoldierFSMState {
    public StateSoldierStandby(SoldierFSMSystem mFSM) : base(mFSM) { }

    public override void Act(GameObject player, GameObject npc) {
        throw new NotImplementedException();
    }

    public override void Reason(GameObject player, GameObject npc) {
        if (true) {
            mFSM.PerformTransition(SoldierTransition.SeeEnemy);
        }
    }
}