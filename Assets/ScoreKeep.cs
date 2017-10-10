using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ScoreKeep : MonoBehaviour {
	public int score;
	public Text display;
	public AudioClip ding;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Collectible") {
			GetComponent<FirstPersonController> ().m_JumpSpeed += 3;
			score++;
			display.text = "Score: " + score;
			GetComponent<AudioSource> ().clip = ding;
			GetComponent<AudioSource> ().Play ();
		} else if (other.tag == "Finish") {
			display.fontSize = 24;
			display.text = "WINNER";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
