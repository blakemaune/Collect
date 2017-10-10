using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {
	public GameObject goal;

	// Use this for initialization
	void Start () {
		goal.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		goal.SetActive (true);
		Destroy (gameObject);
	}
}
