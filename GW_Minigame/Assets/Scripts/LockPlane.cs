using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPlane : MonoBehaviour
{
    private Quaternion correctPlane;

    // Start is called before the first frame update
    void Start()
    {
        correctPlane = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation != correctPlane) {
            transform.rotation = correctPlane;
        }
    }
}
