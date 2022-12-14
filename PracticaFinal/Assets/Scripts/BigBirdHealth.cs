using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBirdHealth : MonoBehaviour, IHealth, IDamageable
{
    private Collider2D bigBirdCollider;
    public float speedMovement = 10;
    private string prefabTag = "BigBird";

    private float timeAlive = 6f;

    public int maxHealth { get; private set; }

    public int currentHealth { get; private set; }

    private void Start()
    {
        maxHealth = 3;
        currentHealth = maxHealth;
    }

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speedMovement;
    }

    private void Awake()
    {
        bigBirdCollider = GetComponent<Collider2D>();
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