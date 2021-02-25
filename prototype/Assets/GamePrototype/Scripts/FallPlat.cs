using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
	public float fallTime = 0.5f;
	public float restoreTime = 3f;


	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
		{
			//Debug.DrawRay(contact.point, contact.normal, Color.white);
			if (collision.gameObject.tag == "Player")
			{
				StartCoroutine(Fall(fallTime));
			}
			StartCoroutine(Restore(restoreTime));
		}
	}

	IEnumerator Fall(float time)
	{
		yield return new WaitForSeconds(time);
		Physics.IgnoreCollision(GetComponent<BoxCollider>(), GameObject.Find("Player").GetComponent<Collider>(),true);
		gameObject.GetComponent<Renderer>().enabled = false;
	}

	IEnumerator Restore(float time) {
		yield return new WaitForSeconds(time);
		Physics.IgnoreCollision(GetComponent<BoxCollider>(), GameObject.Find("Player").GetComponent<Collider>(), false);
		gameObject.GetComponent<Renderer>().enabled = true;
	}
}
