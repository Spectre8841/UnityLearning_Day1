using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    [TextArea]
    public string dialogue = "Xin chào, lữ khách!";

    public void Interact()
    {
        Debug.Log(dialogue);
    }
}
