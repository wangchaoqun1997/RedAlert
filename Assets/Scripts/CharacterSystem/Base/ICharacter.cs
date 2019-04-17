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
    private Animation mAnim;

    protected IWeapon mWeapon;

    public Vector3 position {
        get {
            if (mContent == null) {
                Debug.LogError("mContent为空"); return Vector3.zero;
            }
            return mContent.transform.position;
        }
    }
    public float atkRange {
        get { return mWeapon.atkRange; }
    }

    public void Attack(ICharacter target) {
        if (mWeapon == null) {
            DebugMy.Log("No weapone", this);
            return;
        }
        mWeapon.Fire(target.position);
        PlayAnim("attack");
        mContent.transform.LookAt(target.position);
        target.UnderAttack(mWeapon.atk + mAttr.critValue);
    }

    public virtual void UnderAttack(float damage) {

    }

    public void MoveTo(Vector3 targetPosition) {
        mNavAgent.SetDestination(targetPosition);
        PlayAnim("move");
    }

    public void PlayAnim(string animName) {
        mAnim.CrossFade(animName);
    }

    public void Standby(string animName) {
        PlayAnim(animName);
    }
    protected abstract void UpdateFSMAI(List<ICharacter> targets);

    public virtual void OnUpdate(List<ICharacter> targets) {

    }
}
