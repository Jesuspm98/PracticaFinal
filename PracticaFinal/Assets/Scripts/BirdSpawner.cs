using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject[] birdsPrefabs;

    public Transform[] birdSpawnPositions;

    public float timeToSpawn = 5f;

    private float timeSinceLastSpawn;

    private float timeAlive = 6f;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > timeToSpawn)
        {
            timeSinceLastSpawn = 0;
            int randPref = Random.Range(0, birdsPrefabs.Length);
            int rand = Random.Range(0, birdSpawnPositions.Length);
            Transform randomPos = birdSpawnPositions[rand];
            Instantiate(birdsPrefabs[randPref], birdSpawnPositions[rand].position, birdSpawnPositions[rand].rotation);
        }
    }

    private void TimeToDestroy()
    {
        if (timeAlive >= 6)
        {
            Destroy(gameObject);
        }
    }
}