using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class IAttrStrategy {

    /// <summary>
    /// 根据角色等级提高其总血量
    /// </summary>
    /// <param name="lv"></param>
    protected virtual void GetExtraHP(int lv) {
        DebugMy.Log("GetExtraHP", this);
    }

    /// <summary>
    /// 根据角色等级减少其受到伤害量
    /// </summary>
    /// <param name="lv"></param>
    protected virtual void GetDmgDescValue(int lv) {
        DebugMy.Log("GetDmgDescValue", this);
    }

    /// <summary>
    /// 随机暴击量
    /// </summary>
    /// <param name="critRate"></param>
    protected virtual void GetCritDmg(float critRate) {
        DebugMy.Log("GetCritDmg", this);
    }
}
