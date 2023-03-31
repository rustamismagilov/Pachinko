using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnCollide : MonoBehaviour
{
    // This method is called when an object with the "ScoreTrigger" tag collides with the object
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // If object collides with another object with the "ScoreTrigger" tag
        if (collision.gameObject.CompareTag("ScoreTrigger"))
        {
            // Reference to the ScoreCounter class to use it variables
            ScoreCounter scoreCounter = FindObjectOfType<ScoreCounter>();

            scoreCounter.AddPoints(1);          // Add one point to the score
            scoreCounter.UpdateScoreText();     // Update the score text in the UI
            Destroy(gameObject);                // Destroy the current object
        }
    }
}
