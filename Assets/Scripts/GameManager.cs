using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public LocationListSO locationListSO;
    public CharacterListSO characterListSO;


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
        locationListSO.SetCurrentLocationByName(name);
    }
}
