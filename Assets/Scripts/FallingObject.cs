using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private void OnCollisionEnter()
    {
        Debug.Log("Collision detected with " + gameObject.name);
    }
}