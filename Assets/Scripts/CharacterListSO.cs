using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "CharacterListSO", menuName = "ScriptableObjects/CharacterListSO", order = 0)]
public class CharacterListSO : ScriptableObject
{
    public List<CharacterObject> characterControllers = new List<CharacterObject>();

    public CharacterObject GetCharacterByName(CharacterName name)
    {
        CharacterObject character = characterControllers.Find(character => character.name == name);
        if (character != null) return character;
        return null;
    }
}

[Serializable]
public class CharacterObject
{
    public CharacterName name;
    public GameObject gameObject;

}

[Serializable]
public enum CharacterName
{
    Remy,
    Malaika
}

