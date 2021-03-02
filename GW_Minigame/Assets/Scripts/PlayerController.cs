using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variable declarations
    private float horizontalInput;
    private float verticalInput;
    public float speed = 20.0f;
    public float xRange = 15;
    public float zRange = 15;
    public GameObject projectilePrefab;
    private bool cooldown = true;
    private int downTime = 0;
    private bool gameOver = false;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        // Movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // Play area bounds
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        // Shooting cooldown checker
        if (cooldown) {
            if (downTime < 120) {
                downTime += 1;
            } else {
                downTime = 0;
                cooldown = false;
            }
        }

        // Shootin'
        if (Input.GetKeyDown(KeyCode.Space) && !cooldown && !gameOver) {
            Instantiate(projectilePrefab, transform.position + new Vector3(0, 0, 10), projectilePrefab.transform.rotation);
            cooldown = true;
        }

    }
}
