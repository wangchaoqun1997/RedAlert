using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main3Demo:MonoBehaviour {

    private EnemyFSMSystem mFSMSystem;
    public GameObject player;


    private void MakeFSM() {
        mFSMSystem = new EnemyFSMSystem();

        EnemyFSMState chaseState = new StateEnemyChase(mFSMSystem);
        chaseState.AddTransition(EnemyTransition.SoldierInTheAttackRange, EnemyStateID.AttackState);

        EnemyFSMState attackState = new StateEnemyAttack(mFSMSystem);
        attackState.AddTransition(EnemyTransition.SoldierOutOfTheAttackRange, EnemyStateID.ChaseState);
        
        mFSMSystem.AddState(chaseState);
        mFSMSystem.AddState(attackState);
    }


    public void Start() {
        MakeFSM();
    }

    public void Update() {
        List<ICharacter> character = new List<ICharacter>();
        mFSMSystem.CurrentState.Reason(character);
        mFSMSystem.CurrentState.Act(character);
    }

}