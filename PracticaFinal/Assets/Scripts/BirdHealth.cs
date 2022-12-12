using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdHealth : MonoBehaviour, IHealth, IDamageable
{
    private Collider2D birdCollider;
    public GameObject birdPrefab;

    public int maxHealth { get; private set; }

    public int currentHealth { get; private set; }

    private void Awake()
    {
        birdCollider = GetComponent<Collider2D>();
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damageTaken)
    {
    }

    public void Interact()
    {
    }
}