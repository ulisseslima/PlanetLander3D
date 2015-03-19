using UnityEngine;
using System.Collections;

public class CamBhv : MonoBehaviour {
	GameObject player;
	Rigidbody pbody;
	//Camera camera;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		pbody = player.GetComponent<Rigidbody> ();
		if (pbody == null)
			Debug.LogWarning ("player body not found");
		//camera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 pos = player.transform.position;
		Quaternion rotation = player.transform.rotation;
		pos.z = pos.z - 10;

		transform.position = pos;
		transform.rotation = rotation;
	}
}
