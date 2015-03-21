using UnityEngine;
using System.Collections.Generic;

public class Gravity : MonoBehaviour
{	
	public static float range = 100000;
	
	void FixedUpdate ()
	{
		Collider[] cols = Physics.OverlapSphere (transform.position, range); 
		//Debug.Log ("cols: "+cols.Length);
		List<Rigidbody> rbs = new List<Rigidbody> ();
		
		foreach (Collider c in cols) {
			Debug.Log("c "+ c);
			Rigidbody rb = c.attachedRigidbody;
			if (rb != null && rb != GetComponent<Rigidbody>() && !rbs.Contains (rb)) {
				rbs.Add (rb);
				Vector3 offset = transform.position - c.transform.position;
				Vector3 force = offset / offset.sqrMagnitude * GetComponent<Rigidbody>().mass;
				Debug.Log("force: "+force);
				rb.AddForce (force);
			}
		}
	}
}