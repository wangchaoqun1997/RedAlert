using System;
using System.Collections.Generic;
using System.Text;

public enum Transition {
    NullTransition = 0,

    DonotSeeEnemy,
    SeeEnemy,
    EnemyOutOfTheAttackRange,
    EnemyInTheAttackRange,
}