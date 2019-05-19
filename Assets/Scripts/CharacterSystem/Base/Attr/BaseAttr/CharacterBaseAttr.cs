using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CharacterBaseAttr {
    protected string mName;
    protected int mMaxHP;
    protected float mMoveSpeed;
    protected string mIconSprite;
    protected string mPrefabName;
    /// <summary>
    /// 暴击率，取值范围float 0-1
    /// </summary>
    protected float mCritRate; // 0 - 1暴击率


    public CharacterBaseAttr(string name, int maxHP, float moveSpeed, string iconSprite, string prefabName, float critRate) {
        mName = name;
        mMaxHP = maxHP;
        mMoveSpeed = moveSpeed;
        mIconSprite = iconSprite;
        mPrefabName = prefabName;
        mCritRate = critRate;
    }

    public string name { get { return mName; } }
    public int maxHP { get { return mMaxHP; } }
    public float moveSpeed { get { return mMoveSpeed; } }
    public string iconSprite { get { return mIconSprite; } }
    public string prefabName { get { return mPrefabName; } }
    public float critRate { get { return mCritRate; } }

}


