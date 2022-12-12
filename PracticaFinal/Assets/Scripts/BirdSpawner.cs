using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject[] birdsPrefabs;

    public Transform[] birdSpawnPositions;

    public float timeToSpawn = 5f;

    private float timeSinceLastSpawn;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > timeToSpawn)
        {
            timeSinceLastSpawn = 0;
            int randPref = Random.Range(0, birdsPrefabs.Length);
            int rand = Random.Range(0, birdSpawnPositions.Length);
            Transform randomPos = birdSpawnPositions[rand];
            Instantiate(birdsPrefabs[randPref], randomPos.position, Quaternion.identity);
        }
    }
}