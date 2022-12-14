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
            //SceneManager.LoadScene("LoserScene");
            if (clickManager.currentNumberOfPoints >= 100)
            {
                SceneManager.LoadScene("WinnerScene");
            }
            else if (clickManager.currentNumberOfPoints < 100)
            {
                SceneManager.LoadScene("LoserScene");
            }
        }
        timeToRun -= Time.deltaTime;
        timerText.text = "" + timeToRun.ToString("f0");
    }
}