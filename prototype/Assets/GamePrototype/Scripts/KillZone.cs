using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    public int score;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
			col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
            /*score = GameObject.Find("Player").GetComponent<CharacterControls>().GetScore();
            Debug.Log(score);*/
            GameObject.Find("Player").GetComponent<CharacterControls>().ChangeScore( - 100);

        }
	}
}
