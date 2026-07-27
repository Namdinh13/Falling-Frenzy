using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text sheepLeftText;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private int startingSheepLeft = 5;

    private int currentSheepLeft;

    private void Start()
    {
        currentSheepLeft = startingSheepLeft;
        UpdateText();
    }

    public void LostSheep()
    {
        currentSheepLeft = currentSheepLeft - 1;
        UpdateText();

        if (currentSheepLeft <= 0)
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0f; 
        }
    }

    private void UpdateText()
    {
        sheepLeftText.text = "Sheep Left: " + currentSheepLeft;
    }
}
