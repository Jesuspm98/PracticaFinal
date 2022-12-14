using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timeToRun = 60f;

    private void Update()
    {
        if (timeToRun <= 0)
        {
            SceneManager.LoadScene("LoserScene");
        }
        timeToRun -= Time.deltaTime;
        timerText.text = "" + timeToRun.ToString("f0");
    }
}