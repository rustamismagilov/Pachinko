using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Collections;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public static ScoreCounter instance;
    private int points = 0;

    public Rigidbody2D ballPrefab;
    public Transform spawnPoint;
    public TextMeshProUGUI scoreText;

    private bool hasHit = false;
    private Rigidbody2D currentBall;

    public void Start()
    {
        pointsText = GetComponent<TextMeshProUGUI>();
        UpdatePointsText();
        scoreText.text = "Score: " + ScoreCounter.instance.overallScore;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ScoreTrigger"))
        {
            if (collision.gameObject.CompareTag("Object"))
            {
                AddPoints(1);
                Destroy(collision.gameObject);
                UpdatePointsText();
            }
        }
    }

    public void UpdatePointsText()
    {
        //pointsText.text = "Points: " + instance.GetPoints();
    }

    public int overallScore = 0;

    public static ScoreCounter Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreCounter>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoints(int newPoints)
    {
        points += newPoints;
    }

    public int GetPoints()
    {
        return points;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentBall = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            currentBall.velocity = Vector2.zero;
        }
    }

    public void IncreaseScore()
    {
        if (!hasHit)
        {
            ScoreCounter.instance.overallScore++;
            scoreText.text = "Score: " + ScoreCounter.instance.overallScore;
            hasHit = true;
            //pointSystem.UpdatePointsText();
        }
    }
}
