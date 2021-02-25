using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    public Text FinishText;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Player").GetComponent<CharacterControls>().GetScore();
        ScoreText = this.GetComponent<Text>();
        //StartCoroutine(StartTime());
    }
    void Update()
    {
        score = GameObject.Find("Player").GetComponent<CharacterControls>().GetScore();
        ScoreText.text = "Score: " + (score);
        if (score <0)
        {
            Time.timeScale = 0;
            //Cursor.visible = true;
            CompleteText.txt.SetActive(true);
            Restart.button.SetActive(true);
            NextLevel.button.SetActive(true);
            FinishText = CompleteText.txt.GetComponent<Text>();
            FinishText.text = "You Lose!\nYour have no score!\n Try Again!";
        }
    }
}
