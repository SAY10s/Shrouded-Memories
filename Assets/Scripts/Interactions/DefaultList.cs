using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ListTest : MonoBehaviour, IInteractable, HHintable
{
    private bool showHint = false;

    public void Hint(GameObject uiObject, TMP_Text text)
    {
        if (!showHint)
        {
            uiObject.SetActive(true);
            text.SetText("e: Przeczytaj list");
        }
    }

    public void Interact()
    {
        Task.showCzytaj();
    }
}
