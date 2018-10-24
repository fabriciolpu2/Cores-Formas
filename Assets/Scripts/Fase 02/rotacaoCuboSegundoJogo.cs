using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotacaoCuboSegundoJogo : MonoBehaviour {


    public GameObject cuboPrincipal;
    public bool estado01;
    public bool estado02;
    public bool estado03;
    public bool estado04;
    public float anguloNecessario01;
    public float anguloNecessario02;
    public float anguloNecessario03;
    public float anguloNecessario04;

    //Nao vai ser usado
    public Transform target01;
    public Transform target02;
    public Transform target03;
    public Transform target04;

    //Sensores
    public GameObject baseCirculo;
    public GameObject poligonoCirculo;
    public GameObject trianguloCirculo;
    public GameObject quadradoCirculo;

    public GameObject baloes;
    //animacao principal
    private Animator ab;

    public GameObject textoCirculo;
    public Animator animatorTextoCirculo;

    public GameObject textoPentagono;
    public Animator animatorTextoPentagono;

    public GameObject textoTriangulo;
    public Animator animatorTextoTriangulo;

    public GameObject textoQuadrado;
    public Animator animatorTextoQuadrado;

	public GameObject parabensFim;
	public Animator animatorParabensFim;

    private AudioSource audioSource;
    public AudioClip somCriancas;



    
    // Use this for initialization
    void Start () {
		
        estado02 = false;
        estado01 = false;
        estado03 = false;
        estado04 = false;
        
        baloes = GameObject.Find("Balões");
        ab = baloes.GetComponentInChildren<Animator>();

        // Atribui componentes automaticamente
        textoCirculo = GameObject.FindGameObjectWithTag("textoCirculo");
        animatorTextoCirculo = textoCirculo.GetComponent<Animator>();

        textoPentagono = GameObject.FindGameObjectWithTag("textoPentagono");
        animatorTextoPentagono = textoPentagono.GetComponent<Animator>();

        textoTriangulo = GameObject.FindGameObjectWithTag("textoTriangulo");
        animatorTextoTriangulo = textoTriangulo.GetComponent<Animator>();

        textoQuadrado = GameObject.FindGameObjectWithTag("textoQuadrado");
        animatorTextoQuadrado = textoQuadrado.GetComponent<Animator>();

		
        audioSource = GetComponent<AudioSource>();





    }

    public void TocarAudioCriancas()
    {
        audioSource.PlayOneShot(somCriancas, 1);
    }

    // Update is called once per frame
    void Update () {

        if (estado01 == true) {
            if (cuboPrincipal.transform.eulerAngles.y < anguloNecessario01) {
                cuboPrincipal.transform.Rotate(Vector3.right, 40f * Time.deltaTime);
                cuboPrincipal.transform.position = Vector3.MoveTowards(cuboPrincipal.transform.position, target01.position, 1f * Time.deltaTime);
            } else {
                estado01 = false;
            }
        }
        if (estado02 == true) {
            if (cuboPrincipal.transform.eulerAngles.x < anguloNecessario02) {
                //print(transform.eulerAngles.x);
                cuboPrincipal.transform.Rotate(Vector3.right, 40f * Time.deltaTime);
                cuboPrincipal.transform.position = Vector3.MoveTowards(cuboPrincipal.transform.position, target02.position, 1f * Time.deltaTime);
            }
            else {
                estado02 = false;
            }
        }
        if (estado03 == true)
        {
            if (cuboPrincipal.transform.eulerAngles.x > anguloNecessario03)   
            {
                //print(transform.eulerAngles.x);
                cuboPrincipal.transform.Rotate(Vector3.right, 40f * Time.deltaTime);
                cuboPrincipal.transform.position = Vector3.MoveTowards(cuboPrincipal.transform.position, target03.position, 1f * Time.deltaTime);
            }
            else
            {
                estado03 = false;
            }
        }
        if (estado04 == true)
        {
            if (cuboPrincipal.transform.eulerAngles.x > anguloNecessario04)
            {
                cuboPrincipal.transform.Rotate(Vector3.right, 40f * Time.deltaTime);
                cuboPrincipal.transform.position = Vector3.MoveTowards(cuboPrincipal.transform.position, target04.position, 1f * Time.deltaTime);
            }
            else
            {
                estado04 = false;
            }
        }


    }

    private void OnTriggerEnter(Collider other)
	{
        // Verifica sensor e objeto
		if (other.gameObject.tag == "circulo" && this.gameObject.tag == "circuloBase") {
			estado01 = true;
            
            TocarAudioCriancas();
            ab.Play ("BaloesAnimacao");
            Destroy(other.gameObject);
            PontuacaoSegundoJogo.pontos++;
            animatorTextoCirculo.Play ("CIRCULO");

		} else if (other.gameObject.tag == "poligono" && this.gameObject.tag == "poligonoBase") {
			estado02 = true;
            
            TocarAudioCriancas();
            ab.Play("BaloesAnimacao");
            Destroy(other.gameObject);
            PontuacaoSegundoJogo.pontos++;
            animatorTextoPentagono.Play ("PENTAGONO");

		} else if (other.gameObject.tag == "triangulo" && this.gameObject.tag == "trianguloBase") {
			estado03 = true;
            //Destroy(this.gameObject);
            baloes = GameObject.Find ("Balões");
            TocarAudioCriancas();
            ab.Play ("BaloesAnimacao");
            Destroy(other.gameObject);
            PontuacaoSegundoJogo.pontos++;
            animatorTextoTriangulo.Play ("TRIANGULO");
            

        } else if (other.gameObject.tag == "quadrado" && this.gameObject.tag == "quadradoBase") {
			estado04 = true;
            //Destroy(this.gameObject);
            baloes = GameObject.Find ("Balões");
            TocarAudioCriancas();
			ab.Play ("BaloesAnimacao");
            Destroy(other.gameObject);
            PontuacaoSegundoJogo.pontos++;
            animatorTextoQuadrado.Play ("QUADRADO");
			StartCoroutine ("EspereOsSegundos");

		}  

	}

	IEnumerator EspereOsSegundos () {
		yield return new WaitForSeconds(3);
		//animatorParabensFim.Play ("FimJogo2");
	}



}
