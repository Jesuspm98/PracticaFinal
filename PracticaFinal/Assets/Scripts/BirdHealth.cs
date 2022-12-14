using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdHealth : MonoBehaviour, IHealth, IDamageable
{
    private Collider2D birdCollider;
    public float speedMovement = 10;
    private string prefabTag = "Bird";

    private float timeAlive = 6f;

    public int maxHealth { get; private set; }

    public int currentHealth { get; private set; }

    private void Start()
    {
        maxHealth = 1;
        currentHealth = maxHealth;
    }

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speedMovement;
    }

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
        currentHealth -= damageTaken;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Interact()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(prefabTag))
        {
            Destroy(gameObject);
        }
    }

    public void TimeToDestroy()
    {
        if (timeAlive >= 6)
        {
            Destroy(gameObject);
        }
    }
}