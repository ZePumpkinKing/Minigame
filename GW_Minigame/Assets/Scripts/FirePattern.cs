using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePattern : MonoBehaviour
{
    private bool alternate = true;
    public GameObject projectile;

    void Fire() {

        // Causes enemies to shoot projectiles in a repeating offset pattern
        if (alternate) {
            alternate = false;
            Instantiate(projectile, transform.position + new Vector3(-5, 0, -10), transform.rotation * Quaternion.Euler(0f, 20f, 0f));
            Instantiate(projectile, transform.position + new Vector3(5, 0, -10), transform.rotation * Quaternion.Euler(0f, -20f, 0f));
        } else {
            alternate = true;
            Instantiate(projectile, transform.position + new Vector3(0, 0, -10), transform.rotation);
            Instantiate(projectile, transform.position + new Vector3(-10, 0, -10), transform.rotation * Quaternion.Euler(0f, 40f, 0f));
            Instantiate(projectile, transform.position + new Vector3(10, 0, -10), transform.rotation * Quaternion.Euler(0f, -40f, 0f));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
