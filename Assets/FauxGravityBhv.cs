using UnityEngine;
using System.Collections;

public class FauxGravityBhv : MonoBehaviour {
	public FauxGravityAttractor attractor;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.useGravity = false;
		rb.constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update () {
		attractor.Attract (transform);
	}
}
