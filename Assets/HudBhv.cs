using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HudBhv : MonoBehaviour {
	Text text;
	GameObject player;
	Rigidbody pbody;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		pbody = player.GetComponent<Rigidbody> ();
		if (pbody == null)
			Debug.LogWarning ("player body not found");

		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pp = player.transform.position;
		text.text = string.Format ("x: {0}\ny: {1}\nrotation: {2}\nangularVelocity: {3}\nangularDrag: {4}\nvelocity: {5}",
		                      pp.x, pp.y, player.transform.rotation.z, pbody.angularVelocity, pbody.angularDrag, pbody.velocity);
	}
}
