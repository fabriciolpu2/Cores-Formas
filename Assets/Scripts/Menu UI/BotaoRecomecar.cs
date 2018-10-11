using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotaoRecomecar : MonoBehaviour {

	public GameObject botaoRecomecar;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown (){
        print("Recomeçar");
        //int scene = SceneManager.GetActiveScene().buildIndex;
        Application.LoadLevel(Application.loadedLevel);
        //SceneManager.LoadScene(scene);
	}

}
	
