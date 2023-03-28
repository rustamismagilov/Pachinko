using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] arrayOfObjectsToSpawn;
    public Transform spawnPoint;

    private float lastClickTime = 0f;
    public float clickCooldown = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (UnityEngine.Input.GetMouseButtonDown(0) || UnityEngine.Input.GetKey(KeyCode.Space))
        {
            if (Time.time - lastClickTime > clickCooldown)
            {
                int randomIndex = Random.Range(0, arrayOfObjectsToSpawn.Length);
                GameObject objectToSpawn = arrayOfObjectsToSpawn[randomIndex];

                Instantiate(objectToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
                lastClickTime = Time.time;
            }
        }
    }
}
