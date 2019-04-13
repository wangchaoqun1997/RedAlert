using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class IGameSystem {

    public virtual void OnInit() { }
    public virtual void OnUpdate() { }
    public virtual void OnExit() { }

}
