using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using System;


public static class YarnCommandManager
{

    [YarnCommand("LoadBackground")]
    public static void LoadBackground(string name)
    {
        Debug.Log("Method => LoadBackground => name => "+name);
        GameManager.Instance.SetLocationByName(name); 
    }
}

// This Utility lets you invoke functions with parameters
// https://discussions.unity.com/t/tip-invoke-any-function-with-delay-also-with-parameters/810392
// 
public static class Utility
{
    public static void Invoke(this MonoBehaviour mb, Action f, float delay)
    {
        mb.StartCoroutine(InvokeRoutine(f, delay));
    }

    private static IEnumerator InvokeRoutine(System.Action f, float delay)
    {
        yield return new WaitForSeconds(delay);
        f();
    }
}
