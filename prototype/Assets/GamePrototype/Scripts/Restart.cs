using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public static GameObject button;
    void Start()
    {
        button = GameObject.Find("Restart");
        button.SetActive(false);
        this.GetComponent<Button>().onClick.AddListener(delegate () 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        });
    }
}
