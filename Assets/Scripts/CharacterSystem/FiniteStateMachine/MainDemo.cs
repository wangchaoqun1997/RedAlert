using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class MainDemo:MonoBehaviour {

    private FSMSystem mFSMSystem;
    public GameObject player;

    private void MakeFSM() {
        mFSMSystem = new FSMSystem();

        FSMState standbyState = new StateStandby(mFSMSystem);
        ///standbyState StateID.StandbyState，转换条件分别为
        ///Transition.SeeEnemy
        standbyState.AddTransition(Transition.SeeEnemy, StateID.ChaseState);

        FSMState chaseState = new StateChase(mFSMSystem);
        ///由ChaseState状态可以转换到 StateID.StandbyState StateID.AttackState，转换条件分别为
        ///Transition.DonotSeeEnemy  Transition.EnemyInTheAttackRange
        chaseState.AddTransition(Transition.DonotSeeEnemy, StateID.StandbyState);
        chaseState.AddTransition(Transition.EnemyInTheAttackRange, StateID.AttackState);

        FSMState attackState = new StateAttack(mFSMSystem);
        ///由attackState状态可以转换到 StateID.StandbyState StateID.ChaseState，转换条件分别为
        ///Transition.DonotSeeEnemy  Transition.EnemyOutOfTheAttackRange
        attackState.AddTransition(Transition.DonotSeeEnemy, StateID.StandbyState);
        attackState.AddTransition(Transition.EnemyOutOfTheAttackRange, StateID.ChaseState);

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