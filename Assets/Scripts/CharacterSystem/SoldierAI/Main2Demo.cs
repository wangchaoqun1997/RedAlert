using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main2Demo:MonoBehaviour {

    private SoldierFSMSystem mFSMSystem;
    public GameObject player;

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


    public void Start() {
        MakeFSM();
    }

    public void Update() {
        mFSMSystem.CurrentState.Reason(player, gameObject);
        mFSMSystem.CurrentState.Act(player, gameObject);
    }

}