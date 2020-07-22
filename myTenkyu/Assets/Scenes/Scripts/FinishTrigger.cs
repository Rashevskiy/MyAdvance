using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("FINISH");
        other.transform.SetParent(transform.parent.parent);
        GameObject newLevel = Instantiate(transform.parent.gameObject);
        newLevel.transform.position = new Vector3(0, newLevel.transform.position.y - 90f, newLevel.transform.position.z - 30f);
        newLevel.transform.rotation = Quaternion.identity;
        other.transform.SetParent(newLevel.transform);
        other.GetComponent<AutoControl>().setTarget(newLevel.transform.GetChild(0));
        newLevel.name = "Location";
        newLevel.GetComponent<TouchController>().enabled = false;
        Destroy(transform.parent.gameObject, 2f);
    }
}
