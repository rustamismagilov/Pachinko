using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private int points = 0;

    public TextMeshProUGUI scoreText;

    private bool hasHit = false;
    private ObjectSpawner arrayOfObjectsToSpawn;

    public void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: " + points;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrigger"))
        {
            if (collision.gameObject.CompareTag("Object"))
            {
                IncreaseScore(collision.gameObject);
            }
        }
    }

    public void IncreaseScore(GameObject obj)
    {
        points++;
        scoreText.text = "Score: " + points;
        hasHit = true;
        DeleteOnCollide deleteScript = obj.GetComponent<DeleteOnCollide>();
    }
}
