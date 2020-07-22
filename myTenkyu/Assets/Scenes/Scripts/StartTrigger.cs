using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<AutoControl>().removeTarget();
        transform.parent.GetComponent<TouchController>().enabled = true;
        Debug.Log("START");
    }
}
