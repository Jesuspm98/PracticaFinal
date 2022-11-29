using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdHealth : Health
{
    private Collider2D enemyCollider;
    private Animator enemyAnimator;
    public float timeToDie = 3;

    private void Awake()
    {
        enemyCollider = GetComponent<Collider2D>();
        enemyAnimator = GetComponent<Animator>();
    }

    public override void Die()
    {
        enemyCollider.enabled = false;
        enemyAnimator.SetTrigger("Death");
        StartCoroutine(DeathCorrutine());
    }

    public IEnumerator DeathCorrutine()
    {
        yield return new WaitForSeconds(timeToDie);
        Destroy(gameObject);
    }
}