using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Relogio : MonoBehaviour {

    public float tempoRestante;
    public Text textoTempoRestante;

	public GameObject tenteNovamenteFim;
	public Animator animatortenteNovamenteFim;
    public GameObject animacaoParabens;
    //public Animator animacaoEstrelas;

    // Use this for initialization
    void Start () {
        tempoRestante = 30.0f;
		tenteNovamenteFim = GameObject.FindGameObjectWithTag ("AnimacaoFim");
		animatortenteNovamenteFim = tenteNovamenteFim.GetComponent<Animator> ();      
    }
	
	// Update is called once per frame
	void Update () {
        tempoRestante -= Time.deltaTime;
        textoTempoRestante.text = "Tempo: " + Mathf.Round(tempoRestante);
        //Debug.Log(tempoRestante);
        if (tempoRestante <= 0)
        {
            GameOver();
            //Debug.Log("Era pra parar aqui "+ tempoRestante);
            //StartCoroutine("EspereOsSegundos");
            
        }
        if (PontuacaoSegundoJogo.pontos >= 4)
        {

            Debug.Log("Pontos: " + PontuacaoSegundoJogo.pontos);
            //GameOver();
            StartCoroutine("EspereOsSegundos");

        } 
    }

    public void GameOver() {
        //Destroy(textoTempoRestante);        
        Debug.Log("Parando");
        StartCoroutine("EspereOsSegundos");
        //verificarNotaFinal(PontuacaoSegundoJogo.pontos);

    }

	IEnumerator EspereOsSegundos () {
        Debug.Log("Espere os segundos");
        //Destroy(textoTempoRestante);
        textoTempoRestante.text = "Tempo: 0";
        yield return new WaitForSeconds(2);
        verificarNotaFinal(PontuacaoSegundoJogo.pontos);
        
        //animatortenteNovamenteFim.Play ("FimJogo2Tente");
    }

    void verificarNotaFinal(int pontos)
    {
        Debug.Log("Sera se chegou aqui?" + pontos);
        //animacaoParabens.SetActive(false);
        if (pontos == 1)
        {
            animacaoParabens.SetActive(true);
            Debug.Log("Animacao 1 ponto");
            //animatortenteNovamenteFim.Play("FimJogo2");
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 1 Estrela");
        }
        else if (pontos > 1 && pontos <= 3)
        {
            Debug.Log("Animacao 2 pontos");
            animacaoParabens.SetActive(true);
            //animatortenteNovamenteFim.Play("FimJogo2");
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 2 Estrelas");
        }
        else if (pontos > 3 && pontos <= 4)
        {
            Debug.Log("Animacao 3 ponto");
            //animatortenteNovamenteFim.Play("FimJogo2");
            animacaoParabens.SetActive(true);
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 3 Estrelas");
        }
        else if (pontos == 0)
        {
            Debug.Log("Animacao tente novamente");
            animatortenteNovamenteFim.Play("FimJogo2Tente");            
        }
        

        //Zera a pontuacao
        
    }

}
