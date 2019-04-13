﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.AI;

public abstract class ICharacter {

    protected ICharacterAttr mAttr;

    protected GameObject mContent;
    protected NavMeshAgent mNavAgent;
    protected AudioSource mAudio;
}
