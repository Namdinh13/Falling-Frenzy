using UnityEngine;

public class SheepDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            Destroy(other.gameObject);
        }
    }
}
