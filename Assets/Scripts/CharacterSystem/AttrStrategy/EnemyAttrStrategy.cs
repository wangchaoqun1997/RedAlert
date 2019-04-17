using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EnemyAttrStrategy:IAttrStrategy {

    public override int GetExtraHP(int lv) {
        base.GetExtraHP(lv);
        return 0;
    }

    public override int GetDmgDescValue(int lv) {
        base.GetDmgDescValue(lv);
        return 0;
    }

    public override int GetCritDmg(float critRate) {
        base.GetCritDmg(critRate);
        if (UnityEngine.Random.Range(0, 1f) < critRate) {
            return (int)(10 * UnityEngine.Random.Range(0.5f, 1f));
        }
        return 0;
    }
}
