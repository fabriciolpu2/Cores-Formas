using UnityEngine;
using System.Collections;
// Classe para rotacionar balde e calcular partidas restantes
public class rtest : MonoBehaviour  {

	public GameObject pontoReferencia;
	public bool estado;
	public static int qtdPartidas = 10;


	void Start() {
		estado = true;
	}

	void Update () {
		if (estado == true ) {
            // rotacionar baldes
			transform.RotateAround(pontoReferencia.transform.position, Vector3.up, 50*Time.deltaTime);
		}
	}

}