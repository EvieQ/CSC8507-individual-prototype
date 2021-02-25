using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public static GameObject button;
    void Start()
    {
        button = GameObject.Find("Next");
        button.SetActive(false);
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            SceneManager.LoadScene(1);
        });
    }
}
