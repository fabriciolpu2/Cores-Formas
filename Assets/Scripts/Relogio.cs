using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Relogio : MonoBehaviour {

    public float tempoRestante;
    public Text textoTempoRestante;

	public GameObject tenteNovamenteFim;
	public Animator animatortenteNovamenteFim;

	// Use this for initialization
	void Start () {
        tempoRestante = 30.0f;
		tenteNovamenteFim = GameObject.FindGameObjectWithTag ("AnimacaoFim");
		animatortenteNovamenteFim = tenteNovamenteFim.GetComponent<Animator> ();
    }
	
	// Update is called once per frame
	void Update () {
        tempoRestante -= Time.deltaTime;
        textoTempoRestante.text = "Tempo:" + Mathf.Round(tempoRestante);
        if (tempoRestante < 0)
        {
            GameOver();
        }
    }

    public void GameOver() {
        Destroy(textoTempoRestante);
		StartCoroutine ("EspereOsSegundos");

    }

	IEnumerator EspereOsSegundos () {
		yield return new WaitForSeconds(2);
		animatortenteNovamenteFim.Play ("FimJogo2Tente");
	}

}
