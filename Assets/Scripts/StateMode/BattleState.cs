using Assets.Scripts.FacadeModeAndSingleMode;
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

        FacadeManager.Instant.OnUpdate();
    }

    public override void OnStart() {
        base.OnStart();

        FacadeManager.Instant.OnStart();
    }

    public override void OnExit() {
        base.OnExit();

        FacadeManager.Instant.OnExit();

        StateController.Instant.SetState(new MainMenuState());
    }
}
