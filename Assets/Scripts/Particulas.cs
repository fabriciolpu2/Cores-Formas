using UnityEngine;
using System.Collections;

public class Particulas : MonoBehaviour {

	public GameObject sistemaDeParticulas;

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "BolaVerde" && this.gameObject.tag == "CestoVerde") {
			SoltarParticulas ();
		} else if (collision.gameObject.tag == "BolaAzul" && this.gameObject.tag == "CestoAzul") {
			SoltarParticulas ();
		} else if (collision.gameObject.tag == "BolaVermelha" && this.gameObject.tag == "CestoVermelho") {
			SoltarParticulas ();
		}
	}

	void SoltarParticulas (){

		sistemaDeParticulas.GetComponent<ParticleSystem> ().Play ();
		sistemaDeParticulas.GetComponent<ParticleSystem> ().enableEmission = true;
	}

}
