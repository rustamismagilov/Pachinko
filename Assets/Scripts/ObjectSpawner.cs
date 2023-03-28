using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] arrayOfObjectsToSpawn;  // An array of objects that can be spawned
    public Transform spawnPoint;                // The point where the objects are spawned

    private float lastClickTime = 0f;   // A variable to prevent multiple rapid spawns in quick succession
    public float clickCooldown = 2f;    // The cooldown period between spawns

    // Update is called once per frame
    private void Update()
    {
        // Check if the left mouse button is clicked or the spacebar is pressed
        if (UnityEngine.Input.GetMouseButtonDown(0) || UnityEngine.Input.GetKey(KeyCode.Space))
        {
            // Check if the click cooldown has elapsed
            if (Time.time - lastClickTime > clickCooldown)
            {
                // Choose a random index from the array of objects to spawn
                int randomIndex = Random.Range(0, arrayOfObjectsToSpawn.Length);
                // Get the object to spawn based on the random index
                GameObject objectToSpawn = arrayOfObjectsToSpawn[randomIndex];

                // Spawn the object at the spawn point with the default rotation
                Instantiate(objectToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
                // Update the last click time to prevent rapid spawning
                lastClickTime = Time.time;
            }
        }
    }
}
