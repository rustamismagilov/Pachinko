using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject applePrefab;
    public float spawnInterval = 2f;
    public float minYPosition = 0f;

    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnApple();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnApple()
    {
        float randomX = Random.Range(-2f, 2f);
        Vector3 spawnPosition = new Vector3(randomX, 3f, 0f);
        GameObject apple = Instantiate(applePrefab, spawnPosition, Quaternion.identity);
        Destroy(apple, 2f); // Destroy grounded apple after 2 seconds
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            if (other.transform.position.y < minYPosition)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
