using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    public int currentNumberOfPoints;
    public Text scoreText;
    private bool birdIsDead = false;

    private int scoreAmount = 1;

    //private int bigBirdAmountScore = 3;
    private int damageDealt = 1;

    private void Start()
    {
        scoreText.text = currentNumberOfPoints.ToString();
    }

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
                        if (birdIsDead = true)
                        {
                            GetPoints(scoreAmount);
                        }
                        break;

                    case "BigBird":
                        if (birdIsDead = true)
                        {
                            GetPoints(scoreAmount);
                        }
                        break;

                    default:
                        break;
                }

                IDamageable damageable = hit.collider.gameObject.GetComponent<IDamageable>();

                damageable.TakeDamage(damageDealt);
                //if (health != null)
                //{
                //    health.TakeDamage(damageDealt);
                //}
            }
        }
    }

    public void GetPoints(int pointAmount)
    {
        currentNumberOfPoints += pointAmount;
        scoreText.text = currentNumberOfPoints.ToString();

        //if (currentNumberOfPoints >= 1)
        //{
        //    scoreText.text = currentNumberOfPoints.ToString();
        //    Debug.Log("Obtienes 1 punto");
        //}
    }

    public void IsDead()
    {
        GameObject gameObject = GetComponent<GameObject>();

        if (gameObject != null)
        {
            birdIsDead = false;
        }
        return;
    }
}