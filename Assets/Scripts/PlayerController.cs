using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed;

    private float input;

    private void Update()
    {
        input = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            input = -1f;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            input = 1f;
        }
    }

    private void FixedUpdate()
    {
        Vector3 velocity = new Vector3(input * moveSpeed, 0f, 0f);
        rb.linearVelocity = velocity;
    }
}
