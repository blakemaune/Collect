using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springboard : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		other.gameObject.GetComponent<Rigidbody> ().AddForce (transform.up * 200, ForceMode.Impulse);
	}
}
