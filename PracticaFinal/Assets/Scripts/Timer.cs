using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timeToRun = 60f;

    public ClickManager clickManager;

    private void Start()
    {
        clickManager = FindObjectOfType<ClickManager>();
    }

    private void Update()
    {
        if (timeToRun <= 0)
        {
            Record();
            this.enabled = false;
            //SceneManager.LoadScene("LoserScene");
            //if (clickManager.currentNumberOfPoints >= clickManager.targetNumberOfPoints)
            //{
            //    SceneManager.LoadScene("WinnerScene");
            //}
            //else if (clickManager.currentNumberOfPoints < clickManager.targetNumberOfPoints)
            //{
            //    SceneManager.LoadScene("LoserScene");
            //}
        }
        timeToRun -= Time.deltaTime;
        timerText.text = "" + timeToRun.ToString("f0");
    }

    private void Record()
    {
        if (clickManager.currentNumberOfPoints >= clickManager.targetNumberOfPoints)
        {
            int maxScore = PlayerPrefs.GetInt(clickManager.maxScoreKey);
            if (clickManager.currentNumberOfPoints > maxScore)
            {
                clickManager.scoreText.text = clickManager.currentNumberOfPoints.ToString();

                PlayerPrefs.SetInt(clickManager.maxScoreKey, clickManager.currentNumberOfPoints);
            }
        }
        else /*if (clickManager.currentNumberOfPoints < clickManager.targetNumberOfPoints)*/
        {
            clickManager.scoreText.text = clickManager.currentNumberOfPoints.ToString();
        }
        SceneManager.LoadScene("WinnerScene");
    }
}