using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Czytaj : MonoBehaviour
{
    public TMP_Text tasks;
    public TMP_Text cc;

    public void updateTask(string taskText)
    {
        tasks.SetText(taskText);
    }

    public void subtitles(string taskText)
    {
        cc.SetText(taskText);
    }
}
