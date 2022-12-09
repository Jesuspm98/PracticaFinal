using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdHealth : Health
{
    private Collider2D birdCollider;
    public GameObject birdPrefab;

    private void Awake()
    {
        birdCollider = GetComponent<Collider2D>();
    }

    public override void Die()
    {
        Destroy(gameObject);
    }
}