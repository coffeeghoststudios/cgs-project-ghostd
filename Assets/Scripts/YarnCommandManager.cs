using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public static class YarnCommandManager
{

    [YarnCommand("LoadBackground")]
    public static void LoadBackground(string name)
    {
        GameManager.Instance.SetLocationByName(name); 
    }
}
