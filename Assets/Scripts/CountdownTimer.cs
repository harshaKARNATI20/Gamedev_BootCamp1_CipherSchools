using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;
    public int minutes;
    public int seconds;
    private float remainingTime;
    public event Action onTimerFinished;

    private void Start()
    {
        remainingTime = (minutes * 60) + seconds;
        UpdateTimerText();
    }
    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            remainingTime = 0;
            UpdateTimerText();
            onTimerFinished?.Invoke();
        }

    }
    void UpdateTimerText()
    {
        int displayMinutes = Mathf.FloorToInt(remainingTime / 60);
        int displaySeconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", displayMinutes, displaySeconds);
    }
}
