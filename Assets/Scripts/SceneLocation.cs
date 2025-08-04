using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneLocation : MonoBehaviour
{
    public Image backgroundImage;

    // Start is called before the first frame update
    void Start()
    {
        backgroundImage.sprite = GameManager.Instance.locationSO.currentLocation.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (backgroundImage.sprite != GameManager.Instance.locationSO.currentLocation.sprite)
        {
            backgroundImage.sprite = GameManager.Instance.locationSO.currentLocation.sprite;
        }
    }
}
