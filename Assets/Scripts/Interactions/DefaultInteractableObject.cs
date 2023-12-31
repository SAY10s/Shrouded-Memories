﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DefaultInteractableObject : MonoBehaviour, IInteractable, HHintable
{
    private bool showHint = false;
  
    public void Hint(GameObject uiObject, TMP_Text text)
    {
        if(!showHint)
        {
            uiObject.SetActive(true);
            text.SetText("e: ");
        }
    }

    public void Interact()
    {
        Task.updateTask("Dokonano interakcji");
       
    }
}
