using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : BaseState {
    private float mWaitTime = 0;
    


    public MainMenuState() : base() {
        stateType = StateType.MainMenuState;
        sceneName = SceneName.mainMenuScene;
    }


    public override void OnUpdate() {
        base.OnUpdate();
        mWaitTime += Time.deltaTime;
        if (mWaitTime >= 5) {
            StateController.Instant.SetState(new BattleState());
        }
    }


    public override void OnStart() {
        base.OnStart();
    }


    public override void OnExit() {
        base.OnExit();
    }
}
