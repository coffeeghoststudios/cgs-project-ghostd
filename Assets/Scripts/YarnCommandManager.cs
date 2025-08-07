using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public static class YarnCommandManager
{

    [YarnCommand("LoadBackground")]
    public static void LoadBackground(string name)
    {
        Debug.Log("Method => LoadBackground => name => "+name);
        GameManager.Instance.SetLocationByName(name); 
    }
}
