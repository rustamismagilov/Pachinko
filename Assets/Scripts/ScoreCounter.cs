using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  // A reference to the TextMeshProUGUI component in the scene that will display the score
    private int scorePoints = 0;        // The default score value

    public void Start()
    {
        UpdateScoreText();  // Updates the score text in the UI when the script is first started
    }

    // Update the score displayed in the UI based on the current value of the scorePoints value
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + GetScore();   // Set the text of the scoreText component to the current score
    }

    // This method adds scorePoints to the overall amount of scorePoints
    public void AddPoints(int newPoints)
    {
        scorePoints += newPoints;   // Add new points to the current score
    }

    // This method returns the current score
    public int GetScore()
    {
        return scorePoints; // Return the current score value
    }
}
