using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.FacadeModeAndSingleMode {
    public class FacadeManager {


        private static FacadeManager instant;
        public static FacadeManager Instant {
            get {
                if (instant == null) {
                    instant = new FacadeManager();
                }
                return instant;
            }
        }

        

        public void OnStart() {
            DebugMy.Log("OnStart", this);
        }

        public void OnUpdate() {
            DebugMy.Log("OnUpdate", this);
        }

        public void OnExit() {
            DebugMy.Log("OnExit", this);
        }




    }
}
