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
        //int maxScore = PlayerPrefs.GetInt("MaxScore");
        ////Debug.Log(maxScore);
        //scoreText.text = maxScore.ToString();

        //if (scoreText > maxScore.ToString())
        //{
        //    recordText.enabled = true;
        //}
    }
}