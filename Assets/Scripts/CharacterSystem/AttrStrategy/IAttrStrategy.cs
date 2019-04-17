using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class IAttrStrategy {

    /// <summary>
    /// 根据角色等级提高其总血量
    /// </summary>
    /// <param name="lv"></param>
    public virtual int GetExtraHP(int lv) {
        DebugMy.Log("GetExtraHP", this);
        return 0;
    }

    /// <summary>
    /// 根据角色等级减少其受到伤害量
    /// </summary>
    /// <param name="lv"></param>
    public virtual int GetDmgDescValue(int lv) {
        DebugMy.Log("GetDmgDescValue", this);
        return 0;
    }

    /// <summary>
    /// 随机暴击量
    /// </summary>
    /// <param name="critRate"></param>
    public virtual int GetCritDmg(float critRate) {
        DebugMy.Log("GetCritDmg", this);
        return 0;
    }
}
