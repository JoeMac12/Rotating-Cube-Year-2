using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rotating cube test script
public class rotation : MonoBehaviour
{
    public float rotationspeedX = 10f;
    public float rotationspeedY = 10f;
    public float rotationspeedZ = 10f;

    void Update()
    {
        transform.Rotate(rotationspeedX * Time.deltaTime, rotationspeedY * Time.deltaTime, rotationspeedZ * Time.deltaTime);
    }
}
