using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    private PlayerControls controls;
    private InteractionZone interactionZone;

    private void Awake()
    {
        controls = new PlayerControls();
        interactionZone = GetComponentInChildren<InteractionZone>();
    }

    private void OnEnable()
    {
        controls.Enable();
        controls.Player.Interact.performed += OnInteract;
    }

    private void OnDisable()
    {
        controls.Player.Interact.performed -= OnInteract;
        controls.Disable();
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        Debug.Log("E pressed");
        interactionZone.Interact();
    }
}
