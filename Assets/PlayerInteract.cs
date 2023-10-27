using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

interface IInteractable
{
    public void Interact();
}
interface HHintable
{
    public void Hint(GameObject hint, TMP_Text text);
}


public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 2f;
    public GameObject hint;
    private bool showHint = false;

    public TMP_Text text;
    public Task task;
    public SetState state;

    public void Start()
    {
        //FindObjectOfType<AudioMenager>().Play("Insane");
        Debug.Log("TASK: Rozejrzyj sie po domu");
        hint.SetActive(false);
    }

    void Update()
    {
        showHint = false;
        if (!showHint)
        {
            hint.SetActive(false);
        }

        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out HHintable hintable))
            {
                hintable.Hint(hint, text);
                showHint = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(colliderArray.Length);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out IInteractable interactable))
                {
                    interactable.Interact();
                }
            }
        }
    }
}
