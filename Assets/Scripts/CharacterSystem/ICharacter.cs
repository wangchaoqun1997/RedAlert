using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter {
    protected string mName;
    protected int mMaxHP;
    protected float mMoveSpeed;

    protected int mCurrentHp;

    protected GameObject mContent;
    protected NavMeshAgent mNavAgent;
    protected AudioSource mAudio;

    protected string mIconSprite;
}
