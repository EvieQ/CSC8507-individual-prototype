using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int TotalTime;
    public Text TimeText;
    public int score;
    public Text FinishText;

    void Start() {
        TotalTime = 120;
        TimeText = this.GetComponent<Text>();
        StartCoroutine(StartTime());
    }
    public int GetTime() {
        return TotalTime;
    }
    public IEnumerator StartTime() {
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while (TotalTime >= -1)
        {
            score = GameObject.Find("Player").GetComponent<CharacterControls>().GetScore();
            yield return waitForSeconds;
            if(TotalTime>=0)
                TimeText.text = "Time Left: " + TotalTime + " s";
            TotalTime--;
            if (TotalTime <= -1)
            {
                Time.timeScale = 0;
                //Cursor.visible = true;
                CompleteText.txt.SetActive(true);
                Restart.button.SetActive(true);
                NextLevel.button.SetActive(true);
                FinishText = CompleteText.txt.GetComponent<Text>();
                FinishText.text = "Time Up!\nYour Score is:" + score + "\n Good Job!";
            }
        }
    }
}
