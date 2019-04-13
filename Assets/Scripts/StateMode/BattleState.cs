using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : BaseState {

    public BattleState(){
        stateType = StateType.BattleState;
        sceneName = SceneName.battleScene;
    }
    public override void UpdateAction() {
        base.UpdateAction();
    }

    public override void OnEnter() {
        base.OnEnter();
    }

    public override void OnExit() {
        base.OnExit();
    }
}
