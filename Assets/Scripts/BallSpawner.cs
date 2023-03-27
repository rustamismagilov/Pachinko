using TMPro;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Rigidbody2D ballPrefab;
    public Transform spawnPoint;
    public TextMeshProUGUI scoreText;
    //public PointSystem pointSystem;

    private bool hasHit = false;
    private Rigidbody2D currentBall;

    private void Start()
    {
        scoreText.text = "Score: " + GameManager.instance.overallScore;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (currentBall != null) return;

            currentBall = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            currentBall.velocity = Vector2.zero;
            //hasHit = false;
        }
    }

    public void IncreaseScore()
    {
        if (!hasHit)
        {
            GameManager.instance.overallScore++;
            scoreText.text = "Score: " + GameManager.instance.overallScore;
            hasHit = true;
            //pointSystem.UpdatePointsText();
        }
    }

    //public void ResetHit()
    //{
    //    hasHit = false;
    //}

    public void DespawnBall()
    {
        if (currentBall != null)
        {
            Destroy(currentBall.gameObject);
            currentBall = null;
        }
    }
}
