using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for all dynamic objects that are behind the player
public class StabilizeForceMover : MonoBehaviour
{
    [HideInInspector]
    public Transform mainDynamicObject; // initialized when the trigger starts (DynamicObject.cs)
    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        direction = new Vector2(1, 1);
    }


    void FixedUpdate()
    {
        if(this.gameObject.transform.position.x < mainDynamicObject.position.x - 7)
        {
            rb.AddForce(direction.normalized * 14);
            Debug.Log("acceleration x14");
        }
        else if (this.gameObject.transform.position.x < mainDynamicObject.position.x - 1)
        {
            rb.AddForce(direction.normalized * 4);
            Debug.Log("acceleration x4");

        }
        
   
    }
}
