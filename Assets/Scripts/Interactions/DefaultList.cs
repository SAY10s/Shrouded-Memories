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
        Task.updateTitlet("Placeholder");
        Task.updateLongText("Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, qui dolorem ipsum, quia dolor sit, amet, consectetur");
    }
}
