using UnityEngine;
using System.Collections;

public class MovimentoInicialCamera : MonoBehaviour {
	


	void Update () {
		
		if ((transform.position.y > -2) && (transform.eulerAngles.x < 70)) {
			transform.Translate (0, -10*Time.deltaTime, 0);
			transform.Rotate (-20*Time.deltaTime, 0, 0);
		}
	}
}