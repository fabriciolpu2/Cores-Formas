using UnityEngine;
using System.Collections;

public class rtest : MonoBehaviour  {

	public GameObject pontoReferencia;
	public bool estado;
	public static int qtdPartidas = 10;


	void Start() {
		estado = true;
	}

	void Update () {
		if (estado == true ) {
			transform.RotateAround(pontoReferencia.transform.position, Vector3.up, 50*Time.deltaTime);
		}
	}

}