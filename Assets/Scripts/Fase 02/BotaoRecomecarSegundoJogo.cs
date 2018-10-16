using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotaoRecomecarSegundoJogo : MonoBehaviour {

	public GameObject botaoRecomecar;
	public string menu;
	public string cenaAtual;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Recomecar (){
		print("Recomeçar");
        //int scene = SceneManager.GetActiveScene().buildIndex;
        //Application.LoadLevel(Application.loadedLevel);
        //SceneManager.LoadScene(scene);


        //int scene = SceneManager.GetActiveScene ().buildIndex;
        //SceneManager.LoadScene (scene, LoadSceneMode.Single);
        //Time.timeScale = 1;
        PontuacaoSegundoJogo.pontos = 0;
        SceneManager.LoadScene (cenaAtual);
	}

	public void Menu(){
		print ("menu");
		//Scene scene = SceneManager.GetSceneByBuildIndex (1);
		//SceneManager.LoadScene (scene, LoadSceneMode.Single);
		//Time.timeScale = 1;
		SceneManager.LoadScene (menu);
	}

}
