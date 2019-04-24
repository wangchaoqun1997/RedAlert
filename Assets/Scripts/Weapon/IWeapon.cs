using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public enum WeaponType {
    Gun = 0,
    Rifle = 1,
    Rocket = 2,
    MAX
}
public abstract class IWeapon {

    /// <summary>
    /// 武器的攻击力
    /// </summary>
    protected int mAtk;
    public int atk {
        get {
            return mAtk;
        }
    }

    /// <summary>
    /// 武器攻击力加成
    /// </summary>
    protected int mAtkPlusValue;

    /// <summary>
    /// 武器攻击范围
    /// </summary>
    protected float mAtkRange;
    public float atkRange {
        get {
            return mAtkRange;
        }
    }
    protected GameObject mContent;
    protected ICharacter mOwenr;
    protected ParticleSystem mPariticle;
    protected LineRenderer mLine;
    protected Light mLight;
    protected AudioSource mAudio;

    /// <summary>
    /// 武器名字
    /// </summary>
    protected string mName;

    public IWeapon() {
        mName = this.GetType().ToString();
    }

    public virtual void Fire(Vector3 targetPosition) {
        DebugMy.Log("Fire"+":"+ mName, this);

        ///显示枪口特效
        PlayMuzzleEffect();

        ///显示子弹轨迹特效
        PlayBulletEffect(targetPosition);

        ///设置特效显示时间
        SetEffetDisplayTime();

        ///播放声音
        PlaySound();
    }

    protected virtual void PlayMuzzleEffect() {
        mPariticle.Stop();
        mPariticle.Play();
        mLight.enabled = true;
    }

    protected abstract void PlayBulletEffect(Vector3 targetPosition);
    protected abstract void PlaySound();
    protected abstract void SetEffetDisplayTime();

}
