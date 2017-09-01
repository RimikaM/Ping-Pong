using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public Vector3 initialImpulse;

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.AddForce(initialImpulse, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
