using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//DinamicObject is all Spheres that can be attached for Control
public class DynamicObject : MonoBehaviour
{
    //Attach dynamicObject to MainDynamicObject (Player) and Initialize all components
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StabilizeForceMover stabilizeForceMover = this.gameObject.AddComponent<StabilizeForceMover>();
            Rigidbody2D rb = this.gameObject.AddComponent<Rigidbody2D>();

            rb.drag = 2;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<ControlForceMover>().enabled = true;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.8490566f, 0.4328967f, 0, 1);
            this.gameObject.GetComponent<CircleCollider2D>().enabled = true;
            stabilizeForceMover.mainDynamicObject = collision.transform;
        }
    }

}
