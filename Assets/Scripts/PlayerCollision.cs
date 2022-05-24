using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(-4f, 2f, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(-4f, 0.5f, 0);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "HELIX")
        {
            Destroy(gameObject);
        }
    }
}
