using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseState  {

    public StateController stateController;
    public string sceneName;
    public StateType stateType=StateType.Default;
    AsyncOperation asyncLoad;
    bool isSceneLoaded = false;

    public BaseState() {
    }

    public virtual void UpdateAction() {
        //DebugMy.Log("UpdateAction", this);
        if (!asyncLoad.isDone) {
            DebugMy.Log("UpdateAction isDone==false", this);
            return;
        }
        if (isSceneLoaded == false) {
            DebugMy.Log("UpdateAction SceneLoaded", this);
            isSceneLoaded = true;
            OnEnter();
        }

    }

    public virtual void OnPreEnter() {
        DebugMy.Log("OnPreEnter",this);
        asyncLoad = SceneManager.LoadSceneAsync(sceneName);
    }

    public virtual void OnEnter() {
        DebugMy.Log("OnEnter", this);
    }
    public virtual void OnExit() {
        DebugMy.Log("OnExit", this);
        isSceneLoaded = false;
    }
}
