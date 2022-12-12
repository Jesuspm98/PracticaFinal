using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float movingSpeed = 5;

    public float initialForce = 5;

    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.AddForce(Vector2.zero * initialForce, ForceMode2D.Impulse);

        //transform.position += transform.right * Time.deltaTime * movingSpeed;
    }
}