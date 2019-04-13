using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class IUISystem {

    public virtual void OnInit() {
        DebugMy.Log("OnInit", this);
    }
    public virtual void OnUpdate() {
        DebugMy.Log("OnUpdate", this);
    }
    public virtual void OnExit() {
        DebugMy.Log("OnExit", this);
    }

}
