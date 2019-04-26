using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class FactoryManager {

    private static ResouresLoadFactory mResouresLoadFactory;
    private static WeaponFactory mWeaponFactory;
    private static EnemyFactory mEnemyFactory;
    private static SoldierFactory mSoldierFactory;

    public static ResouresLoadFactory ResouresLoadFactory {
        get {
            if (mResouresLoadFactory == null) {
                mResouresLoadFactory = new ResouresLoadFactory();
            }
            return mResouresLoadFactory;
        }
    }

    public static WeaponFactory weaponFactory {
        get {
            if (mWeaponFactory == null) {
                mWeaponFactory = new WeaponFactory();
            }
            return mWeaponFactory;
        }
    }

    public static EnemyFactory enemyFactory {
        get {
            if (mEnemyFactory == null) {
                mEnemyFactory = new EnemyFactory();
            }
            return mEnemyFactory;
        }
    }

    public static SoldierFactory soldierFactory {
        get {
            if (mSoldierFactory == null) {
                mSoldierFactory = new SoldierFactory();
            }
            return mSoldierFactory;
        }
    }


}