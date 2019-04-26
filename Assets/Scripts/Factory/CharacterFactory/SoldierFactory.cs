using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class SoldierFactory : ICharacterFactory {
    public ICharacter CreateCharacter(string characterName) {
        ISoldier soldier = null;
        string assetName = "";
        switch (characterName) {

            case "Captain":
                assetName = "Captain";
                break;
            case "Captive":
                assetName = "Captive";
                break;
            case "Rookie":
                assetName = "Rookie";
                break;
            case "Sergeant":
                assetName = "Sergeant";
                break;
        }

        IAssetsFactory resoureLoadFactory = new ResouresLoadFactory();
        GameObject GO = resoureLoadFactory.LoadSoldier(assetName);

        switch (characterName) {

            case "Captain":
                soldier = new SoldierCaptain();
                break;
            case "Captive":
                soldier = new SoldierCaptive();
                break;
            case "Rookie":
                soldier = new SoldierRookie();
                break;
            case "Sergeant":
                soldier = new SoldierSergeant();
                break;
        }

        return soldier;
    }
}