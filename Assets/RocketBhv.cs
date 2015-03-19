using UnityEngine;
using System.Collections;

public class RocketBhv : MonoBehaviour
{
	public int upSpeed; // 100
	public int downSpeed; // 100
	public int leftSpeed; // 100
	public int rightSpeed; // 100
	public float moveSpeed; // 15
	private Rigidbody rb;
	private Vector3 moveDir;
	bool jumped;
	bool propelledLeft;
	bool propelledRight;
	
	// Use this for initialization
	void Start ()
	{
		if (moveSpeed < 1)
			Debug.LogWarning ("move speed is less than 1, body will not move");
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (rb == null) {
			Debug.LogWarning ("body not found");
			return;
		}

		jumped = Input.GetButton ("Fire1");
		propelledLeft = Input.GetButton ("Fire2");
		propelledRight = Input.GetButton ("Fire3");

		moveDir = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
	}

	void FixedUpdate ()
	{
		if (jumped) rb.AddForce (Vector2.up * upSpeed);

		rb.MovePosition 
			(rb.position + transform.TransformDirection (moveDir) * moveSpeed * Time.deltaTime);
	}

	void OnGUI ()
	{
//		Event e = Event.current;
//		if (e.isKey) {
//			Debug.Log ("Detected key code: " + e.keyCode);
//		} 
	}
}
