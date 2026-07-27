using UnityEngine;

public class SheepDestroyer : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            gameManager.LostSheep();
            Destroy(other.gameObject);
        }
    }
}
