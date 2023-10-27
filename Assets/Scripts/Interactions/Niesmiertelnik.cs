using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Niesmiertelnik : MonoBehaviour, IInteractable, HHintable
{
    private bool showHint = false;

    public void Hint(GameObject uiObject, TMP_Text text)
    {
        if (!showHint)
        {
            uiObject.SetActive(true);
            text.SetText("e: Odczytaj tekst z nieśmiertelnika");
        }
    }

    public void Interact()
    {
        Task.showCzytaj();
        Task.updateTitlet("Nieśmiertelnik");
        Task.updateLongText("Nikodem \n Majzner \n 01.05.2005 - ");
    }
}
