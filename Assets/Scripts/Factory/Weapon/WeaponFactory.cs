using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class WeaponFactory : IWeaponFactory {
    public IWeapon CreateWeapon(WeaponType type) {

        IWeapon weapon = null;
        switch (type) {

            case WeaponType.Gun:
                weapon =  new WeaponGun();
                break;
            case WeaponType.Rifle:
                weapon = new WeaponRifle();
                break;
            case WeaponType.Rocket:
                weapon = new WeaponRocket();
                break;
        }

        return weapon;

    }
}