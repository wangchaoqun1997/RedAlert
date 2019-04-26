using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class WeaponRifle : IWeapon {
    public WeaponRifle(int atk, int range, GameObject obj) : base(atk, range, obj) {
    }

    protected override void PlayBulletEffect(Vector3 targetPosition) {
        throw new NotImplementedException();
    }

    protected override void PlaySound() {
        throw new NotImplementedException();
    }

    protected override void SetEffetDisplayTime() {
        throw new NotImplementedException();
    }
}