using UnityEngine;
using System.Collections;

public class FauxGravityBhv : MonoBehaviour
{
	public static float range = 100000;
	public FauxGravityAttractor attractor;
	private Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		rb.useGravity = false;
		rb.constraints = RigidbodyConstraints.FreezeRotation;

//		Collider[] cols = Physics.OverlapSphere (transform.position, range); 
//		if (cols.Length < 1)
//			Debug.LogWarning ("no bodies to gravitate to");
//
//		Debug.Log (cols.Length);
//		foreach (Collider c in cols) {
//			Rigidbody rbi = c.attachedRigidbody;
//			if (rbi != null && rbi != GetComponent<Rigidbody>()) {
//				Debug.Log (cols [0].gameObject.name);
//				//attractor = cols [0].gameObject;
//			}
//		}
//
//		if (attractor == null)
//			rb.useGravity = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (attractor != null) {
			attractor.Attract (transform);
			//rb.useGravity = false;
		}
	}
}
