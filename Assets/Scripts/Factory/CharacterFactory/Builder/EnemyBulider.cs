using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class EnemyBulider : ICharacterBuilder {
    public EnemyBulider(ICharacter character, Type t, WeaponType weaponType, Vector3 spawnPosition, int lv) : base(character, t, weaponType, spawnPosition, lv) {
    }

    public override void AddCharacterAttr() {
        throw new NotImplementedException();
    }

    public override void AddGameObject() {
        throw new NotImplementedException();
    }

    public override void AddInCharacterSystem() {
        throw new NotImplementedException();
    }

    public override void AddWeapon() {
        throw new NotImplementedException();
    }

    public override ICharacter GetResult() {
        throw new NotImplementedException();
    }
}