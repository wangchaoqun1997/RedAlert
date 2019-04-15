using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter {

    protected ICharacterAttr mAttr;

    protected GameObject mContent;
    protected NavMeshAgent mNavAgent;
    protected AudioSource mAudio;


    protected IWeapon mWeapone;


    public void Fire(Vector3 targetPosition) {
        if (mWeapone == null) {
            DebugMy.Log("No weapone",this);
            return;
        }
        mWeapone.Fire(targetPosition);
    }

    protected abstract void UpdateFSMAI(List<ICharacter> targets);
}
