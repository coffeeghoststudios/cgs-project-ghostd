using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



[CreateAssetMenu(fileName = "LocationSO", menuName = "ScriptableObjects/LocationSO", order = 0)]
public class LocationSO : ScriptableObject
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
        currentLocation = locations.Find(location => location.type == type);
        Debug.Log("New location is set " + currentLocation);
    }

    public void SetCurrentLocationByName(string name)
    {
       Debug.Log("Location Type for living room => "+LocationType.LivingRoom); 
       currentLocation = locations.Find(location => location.type.ToString() == name); // TODO: Error Handling if location is not found
       Debug.Log("New location is set " + currentLocation);
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
}

[Serializable]
public class Location
{
    public LocationType type = LocationType.None;
    public Sprite sprite;
}