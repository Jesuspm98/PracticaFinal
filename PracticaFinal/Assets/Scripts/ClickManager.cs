using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    public int currentNumberOfPoints;
    public Text pointText;
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
                string hitTag = hit.collider.gameObject.tag;
                switch (hitTag)
                {
                    case "Bird":
                        GetPoints(1);
                        break;

                    case "BigBird":
                        GetPoints(3);
                        break;

                    default:
                        break;
                }
                Health health = hit.collider.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.TakeDamage(damageDealt);
                }
            }
        }
    }

    public void GetPoints(int pointAmount)
    {
        currentNumberOfPoints += pointAmount;
        pointText.text = currentNumberOfPoints.ToString();
    }
}