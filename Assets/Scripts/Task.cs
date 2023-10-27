using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Task : MonoBehaviour
{
    public static Task singleton;
    private void Awake()
    {
        singleton = this;
    }


    public TMP_Text tasks;
    public TMP_Text cc;
    public TMP_Text longText;
    public TMP_Text title;
    public GameObject Czytaj;

    public static void updateTask(string taskText)
    {
        singleton.tasks.SetText(taskText);
    }

    public static void subtitles(string taskText) {
        singleton.cc.SetText(taskText);
    }

    public static void updateLongText(string text)
    {
        singleton.longText.SetText(text);
    }
    public static void updateTitlet(string text)
    {
        singleton.title.SetText(text);
    }
    public static void showCzytaj()
    {
        singleton.Czytaj.SetActive(true);
        Time.timeScale = 0;
    }
}
