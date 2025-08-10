using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public LocationListSO locationListSO;
    public CharacterListSO characterListSO;
    public Button contBtn;
    public Image contBtnImg;
    public DialogueRunner runner;



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

        locationListSO.ResetLocationSO();

    }

    private void Update()
    {
        runner.VariableStorage.TryGetValue<bool>("$hideDialogueContinue", out var hideContBtn);
        if (hideContBtn)
        {
            contBtn.enabled = false;
            contBtnImg.enabled = false;

        }
        else
        {
            contBtn.enabled = true;
            contBtnImg.enabled = true;
        }
    }

    public Location GetCurrentLocation()
    {
        return locationListSO.currentLocation;
    }

    public Sprite GetCurrentLocationSprite()
    {
        return GetCurrentLocation().sprite;
    }
    public LocationType GetCurrentLocationType()
    {
        return GetCurrentLocation().type;
    }
    public void SetLocationByName(string name)
    {
        Debug.Log("Method => SetLocationByName => name => "+name);
        locationListSO.SetCurrentLocationByName(name);
    }
}
