using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class IWeapon {

    protected string mName;

    public IWeapon() {
        mName = this.GetType().ToString();
    }

    public virtual void Fire(Vector3 targetPosition) {
        DebugMy.Log("Fire"+":"+ mName, this);
    }

}
