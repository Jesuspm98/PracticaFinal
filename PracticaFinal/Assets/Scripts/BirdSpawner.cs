using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefabs;

    public Transform[] birdSpawnPositions;

    public float timeToSpawn = 5f;

    private void Update()
    {
    }
}