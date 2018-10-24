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

    // Usado no inicio do jogo
    void Start () {
        tempoRestante = 30.0f;
		tenteNovamenteFim = GameObject.FindGameObjectWithTag ("AnimacaoFim");
		animatortenteNovamenteFim = tenteNovamenteFim.GetComponent<Animator> ();      
    }
	
	// chamado a cada frame
	void Update () {
        //regride tempo
        tempoRestante -= Time.deltaTime;
        textoTempoRestante.text = "Tempo: " + Mathf.Round(tempoRestante);

        if (tempoRestante <= 0)
        {
            GameOver();
        }
        if (PontuacaoSegundoJogo.pontos >= 4)
        {
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

        textoTempoRestante.text = "Tempo: 0";
        yield return new WaitForSeconds(2);
        verificarNotaFinal(PontuacaoSegundoJogo.pontos);
        
     
    }

    void verificarNotaFinal(int pontos)
    {        
        if (pontos == 1)
        {
            animacaoParabens.SetActive(true);        
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 1 Estrela");
        }
        else if (pontos > 1 && pontos <= 3)
        {
            animacaoParabens.SetActive(true);        
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 2 Estrelas");
        }
        else if (pontos > 3 && pontos <= 4)
        {
            animacaoParabens.SetActive(true);
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 3 Estrelas");
        }
        else if (pontos == 0)
        {
            animatortenteNovamenteFim.Play("FimJogo2Tente");            
        }
        

        //Zera a pontuacao
        
    }

}
