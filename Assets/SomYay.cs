using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomYay : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip somYay;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Yay (){
		print("Yay");
		audioSource.PlayOneShot (somYay, 1);
	}

}
