using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour
{
    public GameObject[] prefabs;
    private float spawnRangeX = 74;
    private float spawnPosZ = 60;

    void SpawnRandom() {
        
        // Item selection and position randomization
        int index = Random.Range(0, prefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Spawner
        Instantiate(prefabs[index], spawnPos, prefabs[index].transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawns items infinitely
        InvokeRepeating("SpawnRandom", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}