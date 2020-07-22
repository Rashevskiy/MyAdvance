using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoControl : MonoBehaviour
{
    public float step;

    private float progress;
    private Transform target;
    
    void Start()
    {
        setTarget(transform.parent.GetChild(1));
    }

    
    void Update()
    {
        if(target != null)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, progress);
            progress += step;
        }
    }

    public void setTarget(Transform targetObject)
    {
        transform.GetComponent<Rigidbody>().isKinematic = true;
        target = targetObject;
    }
    public void removeTarget()
    {
        transform.GetComponent<Rigidbody>().isKinematic = false;
        target = null;
    }
}
