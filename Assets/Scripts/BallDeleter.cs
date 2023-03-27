using UnityEngine;

public class BallDeleter : MonoBehaviour
{
    public Rigidbody2D ballPrefab;
    private Vector3 mousePos;

    private void Update()
    {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            Rigidbody2D newBall = Instantiate(ballPrefab, mousePos, Quaternion.identity);
            newBall.velocity = Vector2.zero;
        }
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Destroy(gameObject);
        }
    }
}
