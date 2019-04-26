using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class WeaponFactory : IWeaponFactory {
    public IWeapon CreateWeapon(WeaponType type) {

        IWeapon weapon = null;
        string assetName="";
        switch (type) {

            case WeaponType.Gun:
                assetName = "Gun";
                break;
            case WeaponType.Rifle:
                assetName = "Rifle";
                break;
            case WeaponType.Rocket:
                assetName = "Rocket";
                break;
        }

        IAssetsFactory resoureLoadFactory = new ResouresLoadFactory();
        GameObject GO= resoureLoadFactory.LoadWeapon(assetName);

        switch (type) {

            case WeaponType.Gun:
                weapon =  new WeaponGun(30,4,GO);
                break;
            case WeaponType.Rifle:
                weapon = new WeaponRifle(40, 6, GO);
                break;
            case WeaponType.Rocket:
                weapon = new WeaponRocket(60, 8, GO);
                break;
        }

        return weapon;

    }
}