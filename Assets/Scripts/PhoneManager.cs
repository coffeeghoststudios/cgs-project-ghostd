using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> screens = new List<GameObject>();
    public GameObject DialogScreen;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScreen(string name)
    {
        screens.ForEach(screen =>
        {
            if (screen.name == name)
            {
                screen.SetActive(true);
            }
            else
            {
                screen.SetActive(false);
            }

            if(name == "Game") DialogScreen.SetActive(true);
            
           
           Debug.Log("Game object name "+ screen.name);
        } );

    }
}
