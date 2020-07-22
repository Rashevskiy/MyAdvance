using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distanceX;
    public float distanceY;
    public float distanceZ;

    public float speed;
    private float progress;


    private Vector3 moveDirection;
    public float velocity;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 targetPos = new Vector3(target.position.x - distanceX, target.position.y - distanceY, target.position.z - distanceZ);
        // transform.position = Vector3.Lerp(transform.position,targetPos,progress);
        // progress += speed;

        moveDirection = (new Vector3(targetPos.x, targetPos.y, targetPos.z) - transform.position).normalized;
        velocity = ((new Vector3(targetPos.x, targetPos.y, targetPos.z) - transform.position).magnitude / 0.5f);
        transform.position += moveDirection * (velocity * Time.deltaTime* 2f);
        transform.LookAt(transform);
    }
}
