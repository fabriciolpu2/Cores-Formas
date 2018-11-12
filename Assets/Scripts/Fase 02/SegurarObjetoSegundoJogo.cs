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
    }



}
