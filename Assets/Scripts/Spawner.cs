using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Reference to the prefab you want to spawn
    public AOIChecker invisibleObject;

    private void Update()
    {
        // Check if spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Checker();
        }
    }

    public void SpawnObject()
    {
        // Instantiate the object at the spawn point's position and rotation
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    void Checker()
    {
        // Check if the spawned line intersects with the invisible object
        if (invisibleObject.IsLineIntersecting(objectToSpawn.GetComponent<Collider2D>()))
        {
            Debug.Log("Line intersects with the invisible object!");
            // Do something when the line intersects
        }
    }
}
