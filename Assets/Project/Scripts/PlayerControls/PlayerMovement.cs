using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerControls controls;
    private Vector2 moveInput;
    public float moveSpeed = 4f;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Move.performed += ctx =>
        {
            moveInput = ctx.ReadValue<Vector2>();
        };

        controls.Player.Move.canceled += ctx =>
        {
            moveInput = Vector2.zero;
        };
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    private void Update()
    {
        Vector3 delta = new Vector3(moveInput.x, moveInput.y, 0f);
        transform.position += delta * moveSpeed * Time.deltaTime;
    }
}
