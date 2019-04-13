using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMy {

    public static void Log(string msg,object obj) {
        Debug.Log("["+ obj.GetType().ToString()+"]:"+msg);
    }

    public static void LogError(string msg, object obj) {
        Debug.LogError("[" + obj.GetType().ToString() + "]:" + msg);
    }

}
