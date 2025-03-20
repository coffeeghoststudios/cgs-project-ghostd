using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charKasumi;
    public GameObject charHaruka;


    void Start()
    {
        fadeScreenIn.SetActive(true);
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter(){
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charKasumi.SetActive(true);
        yield return new WaitForSeconds(2);
        // Text functionality
        yield return new WaitForSeconds(2);
        charHaruka.SetActive(true);

    }
}
