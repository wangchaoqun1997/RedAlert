﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class WeaponGun : IWeapon {
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