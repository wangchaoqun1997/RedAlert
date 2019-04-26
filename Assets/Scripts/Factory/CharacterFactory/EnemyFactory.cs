using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class EnemyFactory : ICharacterFactory {
    public ICharacter CreateCharacter(string characterName) {
        IEnemy enemy = null;
        string assetName = "";
        switch (characterName) {

            case "Elf":
                assetName = "Elf";
                break;
            case "Ogre":
                assetName = "Ogre";
                break;
            case "Troll":
                assetName = "Troll";
                break;
        }

        IAssetsFactory resoureLoadFactory = new ResouresLoadFactory();
        GameObject GO = resoureLoadFactory.LoadSoldier(assetName);

        switch (characterName) {

            case "Elf":
                enemy = new EnemyElf();
                break;
            case "Ogre":
                enemy = new EnemyOgre();
                break;
            case "Troll":
                enemy = new EnemyTroll();
                break;
        }

        return enemy;
    }
}