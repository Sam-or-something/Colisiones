using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        Debug.Log("Contacto");
    }
}
