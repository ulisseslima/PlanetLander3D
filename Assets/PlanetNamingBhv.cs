using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlanetNamingBhv : MonoBehaviour
{
	Text text;
	GameObject player;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		text = transform.GetComponent<Text> ();
		if (text != null)
			text.text = 
				"x" + Random.Range (1, 999) +
				"c" + Random.Range (1, 999);
	}
	
	void OnBecameVisible ()
	{
		//Debug.Log ("visi");
	}

	void OnBecameInvisible ()
	{
		//Debug.Log ("invi");
	}
}
