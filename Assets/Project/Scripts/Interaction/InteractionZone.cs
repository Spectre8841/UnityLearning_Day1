using UnityEngine;

public class InteractionZone : MonoBehaviour
{
    private IInteractable currentInteractable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        currentInteractable = other.GetComponent<IInteractable>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<IInteractable>() != null)
            currentInteractable = null;
    }

    public void Interact()
    {
        currentInteractable?.Interact();
    }
}
