using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ISoldier : ICharacter {
    protected SoldierFSMSystem mFSMSystem;

    public ISoldier() {
        MakeFSM();
    }

    private void MakeFSM() {
        mFSMSystem = new SoldierFSMSystem();

        SoldierFSMState standbyState = new StateSoldierStandby(mFSMSystem);
        standbyState.AddTransition(SoldierTransition.SeeEnemy, SoldierStateID.ChaseState);

        SoldierFSMState chaseState = new StateSoldierChase(mFSMSystem);
        chaseState.AddTransition(SoldierTransition.DonotSeeEnemy, SoldierStateID.StandbyState);
        chaseState.AddTransition(SoldierTransition.EnemyInTheAttackRange, SoldierStateID.AttackState);

        SoldierFSMState attackState = new StateSoldierAttack(mFSMSystem);
        attackState.AddTransition(SoldierTransition.DonotSeeEnemy, SoldierStateID.StandbyState);
        attackState.AddTransition(SoldierTransition.EnemyOutOfTheAttackRange, SoldierStateID.ChaseState);

        mFSMSystem.AddState(standbyState);
        mFSMSystem.AddState(chaseState);
        mFSMSystem.AddState(attackState);
    }

    protected override void UpdateFSMAI(List<ICharacter> enemys) {
        mFSMSystem.CurrentState.Reason(enemys);
        mFSMSystem.CurrentState.Act(enemys);
    }

}
