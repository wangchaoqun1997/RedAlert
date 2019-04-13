using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoState : BaseState {

    private Image mLogo;
    private float mSmoothingSpeed = 1;
    private float mWaitTime = 2;

    public LogoState() : base() {
        stateType = StateType.LogoState;
        sceneName = SceneName.logoScene;
    }

    public override void OnStart() {
        base.OnStart();

        mLogo = GameObject.Find("Logo").GetComponent<Image>();
        mLogo.color = Color.black;

    }

    public override void OnUpdate() {
        base.OnUpdate();

        mLogo.color = Color.Lerp(mLogo.color, Color.white, mSmoothingSpeed * Time.deltaTime);
        mWaitTime -= Time.deltaTime;
        if (mWaitTime <= 0) {
            StateController.Instant.SetState(new MainMenuState());
        }

    }


    public override void OnExit() {
        base.OnExit();
    }
}
