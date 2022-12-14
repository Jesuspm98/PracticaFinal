using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int currentNumberOfPoints;
    public Text scoreText;
    private bool birdIsDead;

    private string birdTag = "Bird";
    private string bigBirdTag = "BigBird";

    private int birdAmountScore = 1;
    private int bigBirdAmountScore = 3;

    private void Start()
    {
        scoreText.text = currentNumberOfPoints.ToString();
    }

    private void Update()
    {
        if (CompareTag(birdTag) && !birdIsDead)
        {
            GetPoints(birdAmountScore);
        }
        else if (CompareTag(bigBirdTag) && !birdIsDead)
        {
            GetPoints(bigBirdAmountScore);
        }
    }

    public void GetPoints(int pointAmount)
    {
        scoreText.text = currentNumberOfPoints.ToString();

        currentNumberOfPoints += pointAmount;

        if (currentNumberOfPoints >= 1)
        {
            scoreText.text = currentNumberOfPoints.ToString();
            Debug.Log("Obtienes 1 punto");
        }
    }

    public void IsDead()
    {
        birdIsDead = !birdIsDead;
    }

    //public void Die()
    //{
    //    IsDead();
    //}
}