using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public float mouseSensitivity;
    public float X_limit;
    public float Z_limit;

    public float speedRotate;

    private float xRotation = 0;
    private float zRotation = 0;

    private Quaternion endRotate;
    private Quaternion startRotate;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
          //  float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
          //  float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
            float mouseX = Input.touches[0].deltaPosition.x * mouseSensitivity;
            float mouseY = Input.touches[0].deltaPosition.y * mouseSensitivity;

            xRotation -= mouseX;
            zRotation += mouseY;
            xRotation = Mathf.Clamp(xRotation, -X_limit, X_limit);
            zRotation = Mathf.Clamp(zRotation, -Z_limit, Z_limit);
            //  transform.localRotation = Quaternion.Euler(xRotation, 0, -zRotation);


            endRotate = Quaternion.Euler(xRotation, 0, -zRotation);
            startRotate = Quaternion.Euler(transform.eulerAngles);
            transform.localRotation = Quaternion.Lerp(startRotate, endRotate, speedRotate * Time.deltaTime);

        }
    }

}
