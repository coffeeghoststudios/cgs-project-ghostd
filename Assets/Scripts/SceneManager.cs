using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager Instance;
    public GameObject fadeScreenIn;
    public GameObject RemyNeutral;
    // public GameObject RemySmile;
    // public GameObject RemySmirk;
    // public GameObject RemyAngry;
    // public GameObject RemyPout;


    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }

        fadeScreenIn.SetActive(true);
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter(){
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);

    }

    
}
