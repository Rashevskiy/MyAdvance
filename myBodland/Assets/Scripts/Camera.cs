using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform targetObject; //Manual Edit by Inspector

    void FixedUpdate()
    {
        transform.position = new Vector3(targetObject.position.x,0,-10);
    }

}
