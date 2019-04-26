using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ResouresLoadFactory : IAssetsFactory {

    public const string SoldierPath = "Characters/Soldier/";
    public const string EnemyPath = "Characters/Enemy/";
    public const string WeaponPath = "Weapons/";
    public const string EffectPath = "Effects/";
    public const string AudioPath = "Audios/";
    public const string SpritePath = "Sprites/";

    public AudioClip LoadAudio(string name) {
        return LoadAsset(AudioPath+name) as AudioClip;
    }

    public GameObject LoadEffect(string name) {
        return InstantiateGameObject(EffectPath + name);
    }

    public GameObject LoadEnemy(string name) {
        return InstantiateGameObject(EffectPath + name);
    }

    public GameObject LoadSoldier(string name) {
        return InstantiateGameObject(SoldierPath + name);
    }

    public Sprite LoadSprite(string name) {
        return LoadAsset(SpritePath + name) as Sprite;
    }

    public GameObject LoadWeapon(string name) {
        return InstantiateGameObject(WeaponPath + name);
    }


    private GameObject InstantiateGameObject(string path) {
        UnityEngine.Object o = LoadAsset(path);
        if (o != null) {
            return GameObject.Instantiate(o) as GameObject;
        }
        return null;
    }
    private UnityEngine.Object LoadAsset(string path) {
        UnityEngine.Object o = Resources.Load(path);
        if (o == null) {
            Debug.LogError("无法加载资源，路径:" + path);
            return null;
        }
        return o;
    }
}