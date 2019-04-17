using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CharacterSystem : IGameSystem {
    public List<ICharacter> mSoldierList = new List<ICharacter>();
    public List<ICharacter> mEnemyList = new List<ICharacter>();



    public void AddSoldier(ISoldier soldier) {
        mSoldierList.Add(soldier);
    }
    public void RemoveSoldier(ISoldier soldier) {
        mSoldierList.Remove(soldier);
    }

    public void AddEnemy(IEnemy enemy) {
        mEnemyList.Add(enemy);
    }
    public void RemoveEnemy(IEnemy enemy) {
        mEnemyList.Remove(enemy);
    }

    public override void OnUpdate() {
        DebugMy.Log("OnUpdate", this);
        OnUpdateSoldiers();
        OnUpdateEnemys();
    }


    public void OnUpdateSoldiers() {
        foreach (ISoldier soldier in mSoldierList) {
            soldier.OnUpdate(mEnemyList);
        }
    }
    public void OnUpdateEnemys() {
        foreach (IEnemy enemy in mEnemyList) {
            enemy.OnUpdate(mSoldierList);
        }
    }

}
