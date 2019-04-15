using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class StateEnemyAttack : EnemyFSMState {

    public StateEnemyAttack(EnemyFSMSystem mFSM, ICharacter mCharacter) : base(mFSM, mCharacter) { }
    private float mAttackTime = 1;
    private float mAttackTimer = 1;

    public override void Act(List<ICharacter> soldiers) {
        if (soldiers == null || soldiers.Count == 0) return;
        mAttackTimer += Time.deltaTime;
        if (mAttackTimer >= mAttackTime) {
            mCharacter.Attack(soldiers[0]);
            mAttackTimer = 0;
        }
    }

    public override void Reason(List<ICharacter> soldiers) {

        if (soldiers == null || soldiers.Count == 0) {
            mFSM.PerformTransition(EnemyTransition.SoldierOutOfTheAttackRange);
        } else {
            float distance = Vector3.Distance(mCharacter.position, soldiers[0].position);
            if (distance > mCharacter.atkRange) {
                mFSM.PerformTransition(EnemyTransition.SoldierOutOfTheAttackRange);
            }
        }
    }
}