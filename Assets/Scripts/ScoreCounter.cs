using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int scorePoints = 0;
    private ScoreMultiplier scoreMultiplier;

    public void Start()
    {
        scoreMultiplier = FindObjectOfType<ScoreMultiplier>(); // Find the ScoreMultiplier component in the scene
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + GetScore();
    }

    public void AddPoints(int newPoints, int scoreMultiplierValue)
    {
        Debug.Log("New points: " + newPoints);
        scorePoints += newPoints * scoreMultiplierValue;
        UpdateScoreText();
    }


    public int GetScore()
    {
        return scorePoints;
    }
}
