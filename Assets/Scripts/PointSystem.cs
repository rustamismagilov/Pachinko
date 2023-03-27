using UnityEngine;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public TextMeshProUGUI pointsText;

    public void Start()
    {
        UpdatePointsText();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            ScoreManager.Instance.AddPoints(1);
            UpdatePointsText();
        }
    }

    public void UpdatePointsText()
    {
        pointsText.text = "Points: " + ScoreManager.Instance.GetPoints();
    }
}
