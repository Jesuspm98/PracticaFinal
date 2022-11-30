using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdHealth : Health
{
    private SpriteRenderer birdRend;
    private Collider2D birdCollider;
    private Animator birdAnimator;
    public float timeToDie = 3;

    public void Awake()
    {
        birdRend = GetComponent<SpriteRenderer>();
        birdCollider = GetComponent<Collider2D>();
        //enemyAnimator = GetComponent<Animator>();
    }

    public override void Die()
    {
        birdRend.enabled = false;
        birdCollider.enabled = false;
        //enemyAnimator.SetTrigger("Death");
        StartCoroutine(DeathCorrutine());
    }

    public IEnumerator DeathCorrutine()
    {
        yield return new WaitForSeconds(timeToDie);
        Destroy(gameObject);
    }
}