using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripter2 : MonoBehaviour
{
    public float rotateSpeed = 200f;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Alpha3))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.fixedDeltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.fixedDeltaTime, Space.Self);
        }
    }
}
