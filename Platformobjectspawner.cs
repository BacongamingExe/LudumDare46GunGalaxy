using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformobjectspawner : MonoBehaviour
{

    public GameObject[] spawnees;
    public Transform spawnPos;
    public GameObject SpawnerDelete;

    int randomInt;

    // Update is called once per frame
    void Update()
    {
        SpawnRandom();       
    }

    void SpawnRandom()
    {
        randomInt = Random.Range(0, spawnees.Length);
        Instantiate(spawnees[randomInt], spawnPos.position, spawnPos.rotation);
        Destroy(SpawnerDelete);
    }
}