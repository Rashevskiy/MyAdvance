using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StaticObject : MonoBehaviour
{
    public GameObject dynamicObject; // for Instantiate()

    // Delete the previous location with all objects when you exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    // Creating a new location with new dynamicObjects when you come into
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject go = Instantiate(this.gameObject);
            go.name = "StaticObject";
            go.transform.position = new Vector3(transform.position.x + 80, 0, 0);
            spawnRandomDynamicObjects(go.transform.position, go);
            Debug.Log("ENTER");
        }
    }

    //create from 6 to 20 random objects in Location
    private void spawnRandomDynamicObjects(Vector2 spawnLocation, GameObject parent)
    {
        int countSphere = Random.Range(6,20);
        for (int i = 0; i < countSphere; i++)
        {
            GameObject GO = Instantiate(dynamicObject);
            float spawnX = Random.Range(spawnLocation.x - 40, spawnLocation.x + 40);
            float spawnY = Random.Range(-3, 3);
            GO.transform.position = new Vector2(spawnX, spawnY);
            GO.transform.parent = parent.transform;
        }
    }
}
