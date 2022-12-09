using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefabs;

    public Transform[] birdSpawnPositions;

    public float timeToSpawn = 5f;

    private float timeSinceLastSpawn;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > timeToSpawn)
        {
            timeSinceLastSpawn = 0;
            int rand = Random.Range(0, birdSpawnPositions.Length);
            Transform randomPos = birdSpawnPositions[rand];
            Instantiate(birdPrefabs, randomPos.position, Quaternion.identity);
        }
    }
}