using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour {

    public Text textoCirculo;
    public Animator animatorTextoCirculo;

	// Use this for initialization
	void Start () {
        animatorTextoCirculo = textoCirculo.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AnimarTextoCirculo() {
        animatorTextoCirculo.Play("CIRCULO");
    }

}
