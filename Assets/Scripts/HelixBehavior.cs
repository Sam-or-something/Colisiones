using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixBehavior : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
    }
}
