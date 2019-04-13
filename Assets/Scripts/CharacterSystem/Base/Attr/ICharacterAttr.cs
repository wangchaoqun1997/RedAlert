using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ICharacterAttr {

    protected string mName;
    protected int mMaxHP;
    protected float mMoveSpeed;

    protected int mCurrentHp;
    protected string mIconSprite;

    /// <summary>
    /// 角色等级
    /// </summary>
    protected int mLv;
    /// <summary>
    /// 暴击率，取值范围float 0-1
    /// </summary>
    protected float mCritRate;

    ///角色等级可以提高角色的总血量和抵御伤害，暴击率可以随机产生暴击，这些都是通过一定的算法来得出
    ///由于算法可能有多种所以使用 策略模式 来使用算法
    protected IAttrStrategy mAttrStrategy;


}
