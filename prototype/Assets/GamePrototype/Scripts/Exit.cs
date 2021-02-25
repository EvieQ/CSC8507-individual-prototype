using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
public class Exit : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        { 
            Application.Quit();
        });
    }
}
