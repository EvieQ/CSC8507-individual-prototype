using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gold : MonoBehaviour
{
    public int score;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
           // score = GameObject.Find("Player").GetComponent<CharacterControls>().GetScore();
           // Debug.Log(score);
            GameObject.Find("Player").GetComponent<CharacterControls>().ChangeScore(50);

        }
    }

}
