using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public int score = 0;
    public Text FinishText;

    void OnTriggerEnter(Collider col)
    {
        score = GameObject.Find("Player").GetComponent<CharacterControls>().GetScore();
        if (col.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            //Cursor.visible = true;
            CompleteText.txt.SetActive(true);
            Restart.button.SetActive(true);
            NextLevel.button.SetActive(true);
            FinishText = CompleteText.txt.GetComponent<Text>();
            FinishText.text = "You Win!\nYour Score is:" + score + "\n Good Job!";
        }
    }
}
