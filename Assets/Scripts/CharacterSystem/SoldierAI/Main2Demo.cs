using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Main2Demo:MonoBehaviour {

    private SoldierFSMSystem mFSMSystem;
    public ICharacter  player;

    private void MakeFSM() {
        mFSMSystem = new SoldierFSMSystem();

        SoldierFSMState standbyState = new StateSoldierStandby(mFSMSystem, player);
        standbyState.AddTransition(SoldierTransition.SeeEnemy, SoldierStateID.ChaseState);

        SoldierFSMState chaseState = new StateSoldierChase(mFSMSystem, player);
        chaseState.AddTransition(SoldierTransition.DonotSeeEnemy, SoldierStateID.StandbyState);
        chaseState.AddTransition(SoldierTransition.EnemyInTheAttackRange, SoldierStateID.AttackState);

        SoldierFSMState attackState = new StateSoldierAttack(mFSMSystem, player);
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
        List<ICharacter> character = new List<ICharacter>();
        mFSMSystem.CurrentState.Reason(character);
        mFSMSystem.CurrentState.Act(character);
    }

}