﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class RemoteFactory : IAssetsFactory {
    public AudioClip LoadAudio(string name) {
        throw new NotImplementedException();
    }

    public GameObject LoadEffect(string name) {
        throw new NotImplementedException();
    }

    public GameObject LoadEnemy(string name) {
        throw new NotImplementedException();
    }

    public GameObject LoadSoldier(string name) {
        throw new NotImplementedException();
    }

    public Sprite LoadSprite(string name) {
        throw new NotImplementedException();
    }

    public GameObject LoadWeapon(string name) {
        throw new NotImplementedException();
    }
}