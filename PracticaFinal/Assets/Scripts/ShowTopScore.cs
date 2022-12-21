using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTopScore : MonoBehaviour
{
    public Text scoreText;
    public Text recordText;

    private void Start()
    {
        int maxScore = PlayerPrefs.GetInt("MaxScore");
        int onRoundScore = PlayerPrefs.GetInt("OnRoundScore");
        //Debug.Log(maxScore);
        scoreText.text = maxScore.ToString();

        if (onRoundScore > maxScore)
        {
            recordText.enabled = true;
        }
    }
}