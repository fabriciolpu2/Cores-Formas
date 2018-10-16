using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PrimeiroJogoPlay : MonoBehaviour {

    public Camera cameraPrincipal;
    public bool? animacaoCamera;
    public GameObject loadLevel;

	
	void Update () {
	    if (animacaoCamera == true)
        {
            if (cameraPrincipal.transform.eulerAngles.y > -5)
            {
                cameraPrincipal.transform.Rotate(-5 * Time.deltaTime, -70 * Time.deltaTime, 0);
            }
            if (cameraPrincipal.transform.position.z < -10)
            {
                cameraPrincipal.transform.Translate(0, 3 * Time.deltaTime, 20 * Time.deltaTime);
            }
            else
            {
                //loadLevel.GetComponent<LevelLoad>().LoadLevel(1);
                SceneManager.LoadScene(3);
            }
        }
	}
	void OnMouseDown(){
		print ("play");
        animacaoCamera = true;    
	}

}