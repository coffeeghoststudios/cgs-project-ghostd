using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



[CreateAssetMenu(fileName = "LocationListSO", menuName = "ScriptableObjects/LocationListSO", order = 0)]
public class LocationListSO : ScriptableObject
{
    public List<Location> locations = new List<Location>();
    public Location currentLocation;

    public Sprite GetSpriteByType(LocationType type)
    {
        Location location = locations.Find(location => location.type == type);
        return location.sprite;
    }
    public void SetCurrentLocationByType(LocationType type)
    {
       Location newLocation = locations.Find(location => location.type == type);
       if (newLocation != null) currentLocation = newLocation;
    }

    public void SetCurrentLocationByName(string name)
    {
       Location newLocation = locations.Find(location => Enum.GetName(typeof(LocationType), location.type) == name); 
       Debug.Log("Method => SetCurrentLocationByName => New Location => "+newLocation.type);
       if (newLocation != null) currentLocation = newLocation;
    }

    public void ResetLocationSO()
    {
      SetCurrentLocationByType(LocationType.Chthonia);
    }
}

[Serializable]
public enum LocationType
{
    None,
    Chthonia,
    LivingRoom,
    Cafe,
    TextBackground
}

[Serializable]
public class Location
{
    public LocationType type;
    public Sprite sprite;
}