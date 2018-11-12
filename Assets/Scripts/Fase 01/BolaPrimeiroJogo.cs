using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BolaPrimeiroJogo : MonoBehaviour {
	
	float tempoInicial;
	float tempo;
	public int contadorDeColisao; // QTD de Quick da bola para destruir
	private int numeracaoBola;
	public Image barraDeForca;
 
	public GameObject vermelhoTexto;
    public GameObject azulTexto;
    public GameObject verdeTexto;
    public GameObject bolaVermelha;
    public GameObject bolaVerde;
    public GameObject bolaAzul;

    private Animator ab;
    public Animator animatorVermelhoTexto;
	public Animator animatorAzulTexto;
	public Animator animatorVerdeTexto;
    
    // Script Instancia Bola
    public GameObject scriptInstanciarPrimeiraBola;

    public GameObject bolaLancada;
    public GameObject bola;


    // Use this for initialization
    void Start () {
		contadorDeColisao = 0;
		scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola> ().bolaCinza1.color = new Color32 (0, 255, 33, 255);
		SetarTextosAoGerarBola();
        GetComponent<BolaPrimeiroJogo>().enabled = true;
	}
		
	void OnMouseDown(){
		scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola> ().estadoBarraDeForca = true;
		tempoInicial = Time.time;
	}

	void OnMouseUp (){
		scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola> ().estadoBarraDeForca = null;
		tempo = Time.time - tempoInicial;
		GetComponent<Rigidbody> ().AddForce(new Vector3(0, 7f+tempo, 4), ForceMode.VelocityChange);
	}
	
    void bolaBaldeCorreto()
    {
        Debug.Log("Balde Correto");

        scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola>().Pontuar();
        Destroy(this.gameObject);
        scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola>().TocarAudioEstrelas();
        scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola>().estadoBarraDeForca = false;
        GerarBola();
    }
    void bolaBaldeErrado()
    {
        Debug.Log("Balde Erradoo");
        Destroy(this.gameObject);
        scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola>().estadoBarraDeForca = false;
        GerarBola();
    }
    private void Update()
    {
        GetComponent<BolaPrimeiroJogo>().enabled = true;
    }
    public void zerarParametros()
    {
        contadorDeColisao = 0;        
    }

    void OnCollisionEnter(Collision collision){

        if (collision.gameObject.tag == "Piso")
        {
            Debug.Log("Tocando no Piso");
            contadorDeColisao = contadorDeColisao + 1;
            if (contadorDeColisao >= 4)
            {
                bolaBaldeErrado();
            }
        }
        // VERDE
        if (collision.gameObject.tag == "CestoVerde" && this.gameObject.tag == "BolaVerde") {            
			animatorVerdeTexto.Play("VERDE");
            bolaBaldeCorreto();
        } else if (collision.gameObject.tag == "CestoVerde" && this.gameObject.tag == "BolaVermelha") {
            bolaBaldeErrado();
        } else if (collision.gameObject.tag == "CestoVerde" && this.gameObject.tag == "BolaAzul") {
            bolaBaldeErrado();
        
        // VERMELHO
        } else if (collision.gameObject.tag == "CestoVermelho" && this.gameObject.tag == "BolaVermelha") {
			animatorVermelhoTexto.Play("VERMELHO");
            bolaBaldeCorreto();
        } else if (collision.gameObject.tag == "CestoVermelho" && this.gameObject.tag == "BolaVerde") {
            bolaBaldeErrado();
        } else if (collision.gameObject.tag == "CestoVermelho" && this.gameObject.tag == "BolaAzul") {
            bolaBaldeErrado();

        // AZUL
        } else if (collision.gameObject.tag == "CestoAzul" && this.gameObject.tag == "BolaAzul") {
			animatorAzulTexto.Play("AZUL");
            bolaBaldeCorreto();
        } else if (collision.gameObject.tag == "CestoAzul" && this.gameObject.tag == "BolaVerde") {
            bolaBaldeErrado();
        } else if (collision.gameObject.tag == "CestoAzul" && this.gameObject.tag == "BolaVermelha") {
            bolaBaldeErrado();
        }
			
		

	}

	void GerarBola () {
        
        Debug.Log("Gerar Bola" + rtest.qtdPartidas);
		scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola> ().BolasUtilizadas ();        
        numeracaoBola = Random.Range(1,3);      
		if (numeracaoBola == 1) {
			Instantiate (bolaVermelha, new Vector3 (-1.78f, 0, -15.41f), Quaternion.identity);
			barraDeForca = scriptInstanciarPrimeiraBola.GetComponent<InstanciarPrimeiraBola> ().barraDeForca;
		} else if (numeracaoBola == 2) {
            Instantiate(bolaAzul, new Vector3 (-1.78f, 0, -15.41f), Quaternion.identity);
		} else {
            Instantiate(bolaVerde, new Vector3 (-1.78f, 0, -15.41f), Quaternion.identity);
		}
		rtest.qtdPartidas = rtest.qtdPartidas - 1;
        //zerarParametros();
        GetComponent<BolaPrimeiroJogo>().enabled = true;
    }

	void SetarTextosAoGerarBola(){
		vermelhoTexto = GameObject.FindGameObjectWithTag("vermelhoTexto");
		animatorVermelhoTexto = vermelhoTexto.GetComponent<Animator>();

		verdeTexto = GameObject.FindGameObjectWithTag("verdeTexto");
		animatorVerdeTexto = verdeTexto.GetComponent<Animator>();

		azulTexto = GameObject.FindGameObjectWithTag("azulTexto");
		animatorAzulTexto = azulTexto.GetComponent<Animator>();
    }
}