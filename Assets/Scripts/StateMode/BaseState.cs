using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseState  {

    public StateController stateController;
    public string sceneName;
    public StateType stateType=StateType.Default;
    AsyncOperation asyncLoad;
    bool isDoStart = false;
    public bool isStateInitFinish {
        get {
            if (asyncLoad.isDone) {
                //DebugMy.Log("UpdateAction SceneLoaded", this);
                return true;
            }
            DebugMy.Log("UpdateAction isStateInitFinish==false", this);
            return false;
        }
    }

    public BaseState() {
    }

    public virtual void OnUpdate() {
        if (! isStateInitFinish) {
            return;
        }
        if (isDoStart == false) {
            isDoStart = true;
            OnStart();
        }
        DebugMy.Log("OnUpdate", this);

    }

    public void OnPreStart() {
        DebugMy.Log("OnPreStart", this);
        asyncLoad = SceneManager.LoadSceneAsync(sceneName);
    }

    public virtual void OnStart() {
        DebugMy.Log("OnStart", this);
    }
    public virtual void OnExit() {
        DebugMy.Log("OnExit", this);
        isDoStart = false;
    }
}
