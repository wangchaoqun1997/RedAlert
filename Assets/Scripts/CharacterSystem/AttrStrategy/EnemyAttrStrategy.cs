using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EnemyAttrStrategy:IAttrStrategy {

    protected override void GetExtraHP(int lv) {
        base.GetExtraHP(lv);
    }

    protected override void GetDmgDescValue(int lv) {
        base.GetDmgDescValue(lv);
    }

    protected override void GetCritDmg(float critRate) {
        base.GetCritDmg(critRate);
    }
}
