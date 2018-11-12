using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PrimeiroJogoPlay : MonoBehaviour {

    public Camera cameraPrincipal;
    public bool? animacaoCamera;    

	
	void Update () {
	    if (animacaoCamera == true)
        {
            SceneManager.LoadScene(3);          
        }
	}
	void OnMouseDown(){
		print ("play");
        animacaoCamera = true;    
	}

}