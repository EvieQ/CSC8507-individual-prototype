using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteText : MonoBehaviour
{
	public static GameObject txt;				

	void Start()
	{
		txt = GameObject.Find("Complete");
		txt.SetActive(false); 
	}
}
