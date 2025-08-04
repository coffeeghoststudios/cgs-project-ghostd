using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneLocation : MonoBehaviour
{
    public Image backgroundImage;
    public GameObject fadeScreenIn;

    // Start is called before the first frame update
    void Start()
    {
        backgroundImage.sprite = GameManager.Instance.GetCurrentLocationSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (backgroundImage.sprite != GameManager.Instance.GetCurrentLocationSprite())
        {
            backgroundImage.sprite = GameManager.Instance.GetCurrentLocationSprite();
            fadeScreenIn.SetActive(true);
            StartCoroutine(EventStarter());
        }
    }

    IEnumerator EventStarter(){
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
    }
}
