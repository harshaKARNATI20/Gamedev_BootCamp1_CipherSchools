using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public GameObject gameOverScreen;
    public CountdownTimer countdownTimer;
    private void OnEnable() {
        countdownTimer.onTimerFinished+=HandleTimerFinished;
    }
    private void OnDisable() {
        countdownTimer.onTimerFinished-=HandleTimerFinished;
    }
    private void HandleTimerFinished(){
        gameOverScreen.SetActive(true);
    }
    public void OnClick_RestartButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);

    }
}
