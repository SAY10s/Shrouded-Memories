using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Knfie : MonoBehaviour, IInteractable, HHintable
{
    private bool showHint = false;
    public Task task;
  
    public void Hint(GameObject uiObject, TMP_Text text)
    {
        if(!showHint)
        {
            uiObject.SetActive(true);
            text.SetText("Wcisnij 'e' aby podniesc noz");
        }
    }

    public void Interact()
    {
        task.updateTask("Zakończ testy");
        Debug.Log("Interakcja!");
    }
}
