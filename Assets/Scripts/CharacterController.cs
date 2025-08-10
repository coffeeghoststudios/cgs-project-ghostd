using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;


// Will expose functions that will controll the characters expressions 
public class CharacterController : MonoBehaviour
{
    public CharacterName name;
    public List<CharacterEmote> characterEmotes = new List<CharacterEmote>();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [YarnCommand("CharacterEnter")]
    public void DisplayCharacter()
    {
        EmoteByType(EmoteType.Enter);
    }

    [YarnCommand("CharacterLeave")]
    public void HideCharacter()
    {
        characterEmotes.ForEach(characterEmotes => characterEmotes.gameObject.SetActive(false));
    }

    // we may need to lift this up on more time into the game manager. We must varify that the correct object exists in the scene before 
    // calling this function. 
    [YarnCommand("SetEmote")]
    public void SetEmote(string emoteString)
    {
        EmoteType emote;
        bool isEmoteValid = Enum.TryParse(emoteString, out emote);
        if (isEmoteValid)
        {
            EmoteByType(emote);
        }
        else
        {
            Debug.LogError("Emote of type " + emoteString + " is not a valid emote. Setting Emote to default type neutral");
            EmoteByType(EmoteType.Neutral);
        }

    }

    private void EmoteByType(EmoteType emote)
    {
        // Hide all emotes that is not the specified type
        characterEmotes.ForEach(characterEmote =>
        {
            if (characterEmote.emote == emote)
            {
                characterEmote.gameObject.SetActive(true);
            }else
            {
             characterEmote.gameObject.SetActive(false);
            }
        });
    }


}

[Serializable]
public enum EmoteType
{
    Neutral,
    Angry,
    Smirk,
    Happy,
    Pout,
    Enter,
}

[Serializable]
public class CharacterEmote
{
    public EmoteType emote;
    public GameObject gameObject;
}