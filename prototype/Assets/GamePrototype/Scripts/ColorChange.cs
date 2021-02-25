using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
	public float restoreTime = 5f;
	public Color oldcolor = new Color(255.0f, 83.0f, 210.0f);
	public Color newcolor = new Color(255.0f, 160.0f, 84.0f);

	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			//Debug.DrawRay(contact.point, contact.normal, Color.white);
			if (collision.gameObject.tag == "Player")
			{
				this.GetComponent<MeshRenderer>().material.color = newcolor;
			}
			StartCoroutine(Restore(restoreTime));
		}
	}

	IEnumerator Restore(float time)
	{
		yield return new WaitForSeconds(time);
		this.GetComponent<MeshRenderer>().material.color = oldcolor;
	}
}
