using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAnim : MonoBehaviour
{
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // causes asteroids to spin in random directions (or at least its supposed to)
        angle = Random.Range(0, 3);
        if (angle < 1) {
            transform.Rotate(Vector3.right, 0.25f);
        } else if (angle > 2) {
            transform.Rotate(Vector3.up, 0.25f);
        } else {
            transform.Rotate(Vector3.forward, 0.25f);
        }
        
    }
}
