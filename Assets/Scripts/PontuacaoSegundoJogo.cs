using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuacaoSegundoJogo : MonoBehaviour {

    private int pontos = 0;
    public Text pontosTexto;

    public void Pontuar()
    {
        pontos = pontos + 1;
        pontosTexto.text = "Pontuação: " + pontos.ToString();
        print(pontos);
    }
}
