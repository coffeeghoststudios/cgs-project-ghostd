using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class PhoneManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> screens = new List<GameObject>();
    public DialogueRunner runner;
    public Animator anim;
    public Canvas phoneCanvas;


    void Start()
    {
        runner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            runner.VariableStorage.TryGetValue<bool>("$enablePhone", out var enablePhone);
            if(!enablePhone)return;
            bool isHidden = anim.GetBool("isHidden");
            anim.SetBool("isHidden", !isHidden);
        }
    }

    [YarnCommand("HidePhone")]
    public void HidePhone()
    {
        anim.SetBool("isHidden", true);
    }

    [YarnCommand("PhoneToForeground")]
    public void PhoneToForeground()
    {
        runner.VariableStorage.SetValue("$hideDialogueContinue", true);
        runner.VariableStorage.SetValue("$phoneInteractable", true);
        phoneCanvas.sortingOrder=2;
    }

    [YarnCommand("PhoneToBackground")]
    public void PhoneToBackground()
    {
        runner.VariableStorage.SetValue("$hideDialogueContinue", false);
        runner.VariableStorage.SetValue("$phoneInteractable", false);
        phoneCanvas.sortingOrder=0;
    }

    [YarnCommand("LoadMatchesTutorial")]
    public void LoadMatchesTutorial()
    {
        runner.RequestHurryUpLine();
    }

    [YarnCommand("TransitionPhoneToForeground")]
    public void TransitionPhoneToForeground()
    {
        runner.VariableStorage.SetValue("$hideDialogueContinue", true);
        this.Invoke(() => PhoneToForeground(), 1.5f);
    } 

    [YarnCommand("LoadPhoneScreen")]
    public void LoadScreen(string name)
    {
        runner.VariableStorage.TryGetValue<bool>("$phoneInteractable", out var phoneInteractable);
        if(!phoneInteractable)return;

        
        runner.VariableStorage.TryGetValue<bool>("$TutorialGhostdHome", out var homeScreenTutorial);
        runner.VariableStorage.TryGetValue<bool>("$TutorialGhostdProfile", out var ghostdProfileTutorial);
        runner.VariableStorage.TryGetValue<bool>("$TutorialGhostdProphecy", out var ghostdProphecyTutorial);
        // runner.VariableStorage.TryGetValue<bool>("$lockPhone", out var lockPhone);

        // if (!lockPhone)
        // {
        //     PhoneToForeground();
        // }
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

            // if (name == "Game") DialogScreen.SetActive(true);
            if (name == "Ghostd Home Screen" && homeScreenTutorial)
            {
                PhoneToBackground();
                runner.RequestNextLine();
                runner.VariableStorage.SetValue("$TutorialGhostdHome", false);
            }
            if (name == "Profiles Screen" && ghostdProfileTutorial)
            {
                PhoneToBackground();
                runner.RequestNextLine();
                runner.VariableStorage.SetValue("$TutorialGhostdProfile", false);
            }
            if (name == "Prophecies Screen" && ghostdProphecyTutorial)
            {
                PhoneToBackground();
                runner.RequestNextLine();
                runner.VariableStorage.SetValue("$TutorialGhostdProphecy", false);
            }


            Debug.Log("Game object name " + screen.name);
        });

    }
}
