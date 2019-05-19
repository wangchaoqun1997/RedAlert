using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ICharacterAttr {


    protected CharacterBaseAttr mBaseAttr;

    public ICharacterAttr(IAttrStrategy strategy, int lv, CharacterBaseAttr baseAttr) {
        mLv = lv;
        mBaseAttr = baseAttr;
        mAttrStrategy = strategy;
        mDmgDescValue = mAttrStrategy.GetDmgDescValue(mLv);
        mCurrentHp = baseAttr.maxHP + mAttrStrategy.GetExtraHP(mLv);
    }

     /// <summary>
    /// 角色等级
    /// </summary>
    protected int mLv;

    protected int mCurrentHp;
    public int currentHp {
        get {
            return mCurrentHp + mAttrStrategy.GetExtraHP(mLv);
        }
    }

    protected int mDmgDescValue;
    protected int dmgDescValue {
        get {
            return mAttrStrategy.GetDmgDescValue(mLv);
        }
    }

    

    ///角色等级可以提高角色的总血量和抵御伤害，暴击率可以随机产生暴击，这些都是通过一定的算法来得出
    ///由于算法可能有多种所以使用 策略模式 来使用算法
    protected IAttrStrategy mAttrStrategy;


    public void TakeDamage(int damage) {
        damage -= mDmgDescValue;
        if (damage < 5) damage = 5;
        mCurrentHp -= damage;
    }
}
