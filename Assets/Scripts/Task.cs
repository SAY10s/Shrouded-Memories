using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Task : MonoBehaviour
{
    public TMP_Text tasks;
    public TMP_Text cc;
    public TMP_Text longText;
    public TMP_Text title;
    public GameObject Czytaj;

    public void updateTask(string taskText)
    {
        tasks.SetText(taskText);
    }

    public void subtitles(string taskText) {
        cc.SetText(taskText);
    }

    public void updateLongText(string text)
    {
        longText.SetText(text);
    }
    public void updateTitlet(string text)
    {
        title.SetText(text);
    }
    public void showCzytaj()
    {
        Czytaj.SetActive(true);
        Time.timeScale = 0;
    }
}
