using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector3 v3Force;
    [SerializeField] KeyCode keyP;
    [SerializeField] KeyCode keyN;
    void FixedUpdate()
    {

        if (Input.GetKey(keyP))
                GetComponent<Rigidbody>().velocity += v3Force;
        if (Input.GetKey(keyN))
                GetComponent<Rigidbody>().velocity -= v3Force;

    }
}
