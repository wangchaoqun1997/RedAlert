using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : BaseState {

    public BattleState(){
        stateType = StateType.BattleState;
        sceneName = SceneName.battleScene;
    }
    public override void OnUpdate() {
        base.OnUpdate();
    }

    public override void OnStart() {
        base.OnStart();
    }

    public override void OnExit() {
        base.OnExit();
    }
}
