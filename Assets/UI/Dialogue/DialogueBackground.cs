using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBackground : MonoBehaviour
{
    public CanvasGroup linePresenterCanvas;
    public CanvasGroup optionPresenterCanvas;
    public Image backgroundImage;


    // Update is called once per frame
    void Update()
    {
        if (linePresenterCanvas.alpha > 0 || optionPresenterCanvas.alpha > 0)
        {
            backgroundImage.enabled = true;
        }

        if (linePresenterCanvas.alpha == 0 && optionPresenterCanvas.alpha == 0)
        {
            backgroundImage.enabled = false;
        }
        
    }
}
