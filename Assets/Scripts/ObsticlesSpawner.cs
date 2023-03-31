using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticlesSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;   // Prefab of the object to be spawned
    public float spacingMin = 1.0f;    // The minimum spacing between the objects
    public float spacingMax = 2.0f;    // The maximum spacing between the objects
    public int rowsMin = 4;            // The minimum number of rows in the layout
    public int rowsMax = 10;           // The maximum number of rows in the layout
    public int colsMin = 4;            // The minimum number of columns in the layout
    public int colsMax = 10;           // The maximum number of columns in the layout
    public Vector3 offset = Vector3.zero;        // The offset for the layout

    void Start()
    {
        // Generate random values for the spacing, rows, and columns
        float spacing = Random.Range(spacingMin, spacingMax);
        int numRows = Random.Range(rowsMin, rowsMax + 1);
        int numCols = Random.Range(colsMin, colsMax + 1);

        // Offset the starting position to center the checkerboard
        float xOffset = (numCols - 1) * spacing / 2.0f;
        float yOffset = (numRows - 1) * spacing / 2.0f;

        // Loop through each row and column, spawning objects
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                // Calculate the position of the object to be spawned
                float x = col * spacing - xOffset;
                float y = row * spacing - yOffset;
                Vector3 position = new Vector3(x, y, 0);

                // Spawn the object at the calculated position
                Instantiate(objectToSpawn, position + offset, Quaternion.identity);
            }
        }
    }
}
