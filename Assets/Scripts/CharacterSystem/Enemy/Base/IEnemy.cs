using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class IEnemy:ICharacter {
    protected EnemyFSMSystem mFSMSystem;

    public IEnemy() {
        MakeFSM();
    }

    private void MakeFSM() {
        mFSMSystem = new EnemyFSMSystem();

        EnemyFSMState chaseState = new StateEnemyChase(mFSMSystem,this);
        chaseState.AddTransition(EnemyTransition.SoldierInTheAttackRange, EnemyStateID.AttackState);

        EnemyFSMState attackState = new StateEnemyAttack(mFSMSystem, this);
        attackState.AddTransition(EnemyTransition.SoldierOutOfTheAttackRange, EnemyStateID.ChaseState);

        mFSMSystem.AddState(chaseState);
        mFSMSystem.AddState(attackState);
    }

    protected override void UpdateFSMAI(List<ICharacter> soldiers) {
        mFSMSystem.CurrentState.Reason(soldiers);
        mFSMSystem.CurrentState.Act(soldiers);
    }
}