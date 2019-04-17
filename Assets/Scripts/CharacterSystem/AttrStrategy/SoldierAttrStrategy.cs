using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SoldierAttrStrategy : IAttrStrategy {

    public override int GetExtraHP(int lv) {
        base.GetExtraHP(lv);
        return (lv - 1) * 10;
    }

    public override int GetDmgDescValue(int lv) {
        base.GetDmgDescValue(lv);
        return (lv - 1) * 5;
    }

    public override int GetCritDmg(float critRate) {
        base.GetCritDmg(critRate);
        return 0;
    }
}
