using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detects colliding items, removing both
    void OnTriggerEnter(Collider other) {
        Instantiate(explosion, other.gameObject.transform.position, other.gameObject.transform.rotation);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
