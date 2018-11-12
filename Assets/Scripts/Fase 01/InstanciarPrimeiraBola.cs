using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstanciarPrimeiraBola : MonoBehaviour {

    // Bolas
	public GameObject bolaVermelha;
	public GameObject bolaAzul;
	public GameObject bolaVerde;
	public Image barraDeForca;
	public bool? estadoBarraDeForca;
	public int numeracaoBola;

    // GUI - Marcam a quantidade de Bolas utilizadas
    public Image bolaCinza1;
	public Image bolaCinza2;
	public Image bolaCinza3;
	public Image bolaCinza4;
	public Image bolaCinza5;
	public Image bolaCinza6;
	public Image bolaCinza7;
	public Image bolaCinza8;
	public Image bolaCinza9;
	public Image bolaCinza10;

	public int bolasUtilizadas = 1;
	public GameObject animacaoParabens;

	private AudioSource audioSource;
	public AudioClip somEstrelas;

    public GameObject bolaUtilizada;


	private int pontos = 0;
	public Text pontosTexto;

	// Use this for initialization
	void Start () {
		estadoBarraDeForca = null;
		numeracaoBola = Random.Range (1,3);
		audioSource = GetComponent<AudioSource> ();
		
	}

    void buscarBola()
    {
        bolaUtilizada = GameObject.FindObjectOfType<BolaPrimeiroJogo>().gameObject;
        bolaUtilizada.GetComponent<BolaPrimeiroJogo>().enabled = true;
    }
    
	// Update is called once per frame
	void Update () {
        buscarBola();        
        if (estadoBarraDeForca == true) {
			barraDeForca.fillAmount = barraDeForca.fillAmount + 0.005f;	
            
		}

		if (estadoBarraDeForca == false) {
			barraDeForca.fillAmount = barraDeForca.fillAmount - 0.01f;
			if (barraDeForca.fillAmount == 0) {
				//estadoBarraDeForca = null;
			}
		}
	}

	public void BolasUtilizadas() {
        bolasUtilizadas = bolasUtilizadas + 1;
        if (bolasUtilizadas == 1) {
            bolaCinza1.color = new Color32(0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 2) {
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
            bolaCinza2.color = new Color32 (0, 255, 33, 255);
		} else if (bolasUtilizadas == 3) {
			bolaCinza3.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 4) {
			bolaCinza4.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 5) {
			bolaCinza5.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 6) {
			bolaCinza6.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 7) {
			bolaCinza7.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 8) {
			bolaCinza8.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 9) {
			bolaCinza9.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 10) {
			bolaCinza10.color = new Color32 (0, 255, 33, 255);
            bolaUtilizada.GetComponent<BolaPrimeiroJogo>().zerarParametros();
        } else if (bolasUtilizadas == 11) {
            // Encerra Jogo
            verificarNotaFinal(pontos);
		}
        
    }
    void verificarNotaFinal(int pontos)
    {
        if (pontos >= 1 && pontos <= 3)
        {
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 1 Estrela");
        }
        else if (pontos > 3 && pontos <= 7)
        {
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 2 Estrelas");
        }
        else if (pontos > 7 && pontos <= 10)
        {
            animacaoParabens.GetComponent<Animator>().Play("Animacao - 3 Estrelas");
        }
        else if (pontos == 0)
        {
            animacaoParabens.GetComponent<Animator>().Play("Tente Novamente");
        }
    }


    // Funções utilizadas no Script Bola Primeiro Jogo
    public void Pontuar()
    {
        pontos = pontos + 1;
        pontosTexto.text = "Pontuação: " + pontos.ToString();
    }
    public void TocarAudioEstrelas(){
		audioSource.PlayOneShot (somEstrelas, 1);
	}
}