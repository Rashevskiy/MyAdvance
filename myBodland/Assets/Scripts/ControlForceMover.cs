using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// impulse by left click
public class ControlForceMover : MonoBehaviour
{
    [Header("MANUAL EDIT")]
    public float acceleration; //Manual Edit by Inspector for set force

    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        direction = new Vector2(1,1);
    }

    
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("press Button");
            rb.AddForce(direction.normalized * acceleration, ForceMode2D.Impulse);
        }
    }
}
