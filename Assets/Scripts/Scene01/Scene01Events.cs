using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using System;


public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    // public GameObject charKasumi;
    // public GameObject charHaruka;
    // public GameObject leftCharParent;

    public GameObject RemyNeutral;
    public GameObject RemySmile;
    public GameObject RemySmirk;
    public GameObject RemyAngry;
    public GameObject RemyPout;




    [SerializeField] AudioSource sigh;
    [SerializeField] AudioSource gasp;

    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;






    void Start()
    {
        // if(Screen.width < 415){
        //   Debug.Log("screen width is mobile width");
        //   leftCharParent.transform.position = new Vector2(200, 0);
        // }
        // Debug.Log("display width "+Screen.width); 
        fadeScreenIn.SetActive(true);
        StartCoroutine(EventStarter());
    }

    [YarnCommand("EnterRemy")]
    public void EnterRemy()
    {
        RemyNeutral.SetActive(true);
    }

    [YarnCommand("RemySmile")]
    public void RemySmileCmd()
    {
        RemySmile.SetActive(true);
        this.Invoke(() =>HideCharacter(RemySmile), 3f);
    }

    [YarnCommand("RemySmirk")]
    public void RemySmirkCmd()
    {
        RemySmirk.SetActive(true);
        this.Invoke(() =>HideCharacter(RemySmirk), 3f);
    }

    [YarnCommand("RemyAngry")]
    public void RemyAngryCmd()
    {
        RemyAngry.SetActive(true);
        this.Invoke(() =>HideCharacter(RemyAngry), 3f);
    }

    [YarnCommand("RemyPout")]
    public void RemyPoutCmd()
    {
        RemyPout.SetActive(true);
        this.Invoke(() =>HideCharacter(RemyPout), 3f);
    }

    public void HideCharacter(GameObject character)
    {
        character.SetActive(false);
    }

    IEnumerator EventStarter(){
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        // charKasumi.SetActive(true);
        // gasp.Play();
        // yield return new WaitForSeconds(2);
        // // Text functionality
        // yield return new WaitForSeconds(2);
        // charHaruka.SetActive(true);
        // sigh.Play();

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
