using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject self;
    private float currentScale;
    private Vector3 newScale;

    // Start is called before the first frame update
    void Start()
    {
        currentScale = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        newScale = new Vector3(currentScale, currentScale, currentScale);
        self.transform.localScale = (newScale);
        currentScale += 1f * Time.deltaTime;
        if (currentScale > 0.5f) {
            Destroy(self);
        }
    }
}
