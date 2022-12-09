using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float movingSpeed = 20;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * movingSpeed;
    }
}