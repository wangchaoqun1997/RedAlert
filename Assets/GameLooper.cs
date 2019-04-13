using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLooper : MonoBehaviour {

    public static GameLooper instant;

    void Awake() {
        if (instant != null) {
            DestroyImmediate(gameObject);
            return;
        }
        instant = this;
        DontDestroyOnLoad(this);
    }

	// Use this for initialization
	void Start () {
        StateController.Instant.SetState(new MainMenuState());
    }
	
	// Update is called once per frame
	void Update () {
        StateController.Instant.UpdateAction();
	}
}
