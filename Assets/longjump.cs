using UnityEngine;
using System.Collections;

public class longjump : MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 100);		
		}
	}

	void OnCollisionsEnter(Collision other){
		if (other.gameObject.tag == "tabrak") {
			other.gameObject.audio.Play ();
		}
	}
	void OnCollisionExit(Collision other) {
	}
}


