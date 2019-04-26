using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public interface IAssetsFactory {
    GameObject LoadSoldier(string name);
    GameObject LoadEnemy(string name);
    GameObject LoadWeapon(string name);
    GameObject LoadEffect(string name);
    AudioClip LoadAudio(string name);
    Sprite LoadSprite(string name);
}