using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateSoldierAttack : SoldierFSMState {

    public StateSoldierAttack(SoldierFSMSystem mFSM,ICharacter mCharacter) : base(mFSM, mCharacter) { }
    private float mAttackTime = 1;
    private float mAttackTimer = 1;

    public override void Act(List<ICharacter> enemys) {
        if (enemys == null || enemys.Count == 0) return;
        mAttackTimer += Time.deltaTime;
        if (mAttackTimer >= mAttackTime) {
            mCharacter.Attack(enemys[0]);
            mAttackTimer = 0;
        }
    }

    public override void Reason(List<ICharacter> enemys) {
        
        if (enemys == null || enemys.Count == 0) {
            mFSM.PerformTransition(SoldierTransition.DonotSeeEnemy);
            return;
        }

        float distance = Vector3.Distance(mCharacter.position, enemys[0].position);
        if (distance > mCharacter.atkRange) {
            mFSM.PerformTransition(SoldierTransition.EnemyOutOfTheAttackRange);
            return;
        }
    }
}