using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHit : MonoBehaviour
{
    private int damageDealt = 1;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = Vector2.zero;
            RaycastHit2D hit = Physics2D.Raycast(origin, dir);
            if (hit)
            {
                Health health = hit.collider.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(damageDealt);
                }
            }
        }
    }
}