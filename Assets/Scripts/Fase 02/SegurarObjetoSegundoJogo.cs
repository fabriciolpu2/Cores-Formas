using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegurarObjetoSegundoJogo : MonoBehaviour
{

    float distancia = 2.5f;
    public GameObject circulo;
    public int pontuacao = 0;

    private void OnMouseDrag()
    {
        Vector3 posicao = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distancia);
        Vector3 posicaoDoObjeto = Camera.main.ScreenToWorldPoint(posicao);
        transform.position = posicaoDoObjeto;
        
        //PontuacaoSegundoJogo.pontos ++;
        //Debug.Log("aqui "+ PontuacaoSegundoJogo.pontos);
    }

    private void OnTriggerEnter(Collider collision)
    {
        /*
        if (collision.gameObject.tag == "circuloBase" && this.gameObject.tag == "circulo")
        {
            //Destroy(this.gameObject);
            print("Acertou, círculo aqui!");
            pontuacao++;
        }
        else if (collision.gameObject.tag == "circuloBase" && this.gameObject.tag != "circulo")
        {
            print("Errou. Objeto volta!");

            //collision.gameObject.transform.position = new Vector3(1, 1, 1);
        }
        else if (collision.gameObject.tag == "quadradoBase" && this.gameObject.tag == "quadrado")
        {
            Destroy(this.gameObject);
            print("Acertou, quadrado!");
            pontuacao++;
        }
        else if (collision.gameObject.tag == "quadradoBase" && this.gameObject.tag != "quadrado")
        {
            collision.gameObject.transform.position = new Vector3(1, 1, 1);
        }
        else if (collision.gameObject.tag == "trianguloBase" && this.gameObject.tag == "triangulo")
        {
            Destroy(this.gameObject);
            print("Acertou, triângulo!");
            pontuacao++;
        }
        else if (collision.gameObject.tag == "trianguloBase" && this.gameObject.tag != "triangulo")
        {
            print("Errou. Objeto volta!");
        }
        else if (collision.gameObject.tag == "poligonoBase" && this.gameObject.tag == "poligono")
        {
            Destroy(this.gameObject);
            print("Acertou, Hexágono!");
            pontuacao++;
        }
        else if (collision.gameObject.tag == "poligonoBase" && this.gameObject.tag != "poligono")
        {
            print("Errou. Objeto volta!");
        }
        */
    }


}
