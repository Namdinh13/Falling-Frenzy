using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        float input = 0f;

        if (Keyboard.current.aKey.isPressed)
        {
            input = -1f;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            input = 1f;
        }
        
        Debug.Log(input);
    }
}
