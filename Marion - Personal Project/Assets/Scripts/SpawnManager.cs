using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject buildingPrefab;
    public GameObject personPrefab;
    public float spawnRange = 70.0f;
    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; 1 < 3; i = i++)
        //{
        Instantiate(buildingPrefab, RandomSpawnPosition(), buildingPrefab.transform.rotation);
        //}

        //for(int i = 0; 1 < 3; i = i++)
        //{
        Instantiate(personPrefab, NewSpawnPosition(), personPrefab.transform.rotation);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 RandomSpawnPosition()
    {
        // spawns buildings in random spots on the screen
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 3.25f, spawnPosZ);
        return randomPos;
    }

    private Vector3 NewSpawnPosition()
    {
        // spawns people in random spots on the screen
        float goPosX = Random.Range(-spawnRange, spawnRange);
        float goPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 newPos = new Vector3(goPosX, 0.5f, goPosZ);
        return newPos;
    }
}
