using UnityEngine;
using System.Collections;

public class MudarIntensidadeHDR : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Renderer renderer = GetComponent<Renderer> ();
		Material mat = renderer.material;

		//float emission = Mathf.PingPong (Time.time, 0.2f);

		float floor = 0f;
		float ceiling = 0.4f;
		float emission = floor + Mathf.PingPong(Time.time*0.6f, ceiling - floor);


		Color baseColor = new Color32( 0xFF, 0xFF, 0xFF, 0xFF ); //Replace this with whatever you want for your base color at emission level '1'

		Color finalColor = baseColor * Mathf.LinearToGammaSpace (emission);

		mat.SetColor ("_EmissionColor", finalColor);
	}
}
