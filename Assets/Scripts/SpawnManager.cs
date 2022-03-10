using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPerfab;
    private float spawnInterval = 1.5f;
    private float startDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomHardles", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomHardles()
    {
        int spawnIndex = Random.Range(0, spawnPerfab.Length);
        Instantiate(spawnPerfab[spawnIndex]);
    }
        
}
