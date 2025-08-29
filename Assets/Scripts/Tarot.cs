using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;



public class Tarot : MonoBehaviour
{
    public GameObject Death;
    public GameObject World;
    public GameObject ThreeOfWands;
    public GameObject FourOfCups;

    [YarnCommand("ShowDeath")]
    public void DisplayDeath()
    {
        Death.SetActive(true);
    }


    [YarnCommand("ShowWorld")]
    public void DisplayWorld()
    {
        World.SetActive(true);
    }


    [YarnCommand("ShowThreeOfWands")]
    public void DisplayThreeOfWands()
    {
        ThreeOfWands.SetActive(true);
    }


    [YarnCommand("ShowFourOfCups")]
    public void DisplayFourOfCups()
    {
        FourOfCups.SetActive(true);
    }

    [YarnCommand("HideDeck")]
    public void HideDeck()
    {
         Death.SetActive(false);
         ThreeOfWands.SetActive(false);
         World.SetActive(false);
         FourOfCups.SetActive(false);
    }
}
