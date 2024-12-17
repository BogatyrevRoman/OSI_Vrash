using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripter : MonoBehaviour
{
    public float rotateSpeed = 25f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            transform.Rotate(Vector3.back * rotateSpeed * Time.fixedDeltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            transform.Rotate(Vector3.forward * rotateSpeed * Time.fixedDeltaTime, Space.Self);
        }
    }
}
