using UnityEngine;
using System.Collections;

public class RotacaoEfeitoNome : MonoBehaviour {
	
	//Variável para guardar velocidade da rotação. Acesso público.
	public int velocidadeRotacao = -50;
	//Variável para guardar tamanho inicial. Acesso público.
	public float tamanhoDoEfeito = 1;

	//Inicialização padrão de todo script Unity.
	void Start () {
	
	}
	
	//Atualização padrão de todo script Unity. É chamado uma vez por imagem (frame);
	void Update () {
		
		transform.Rotate(0, 0, velocidadeRotacao * Time.deltaTime);
		if (tamanhoDoEfeito > -2) {
			transform.localScale = new Vector3 (tamanhoDoEfeito, tamanhoDoEfeito, tamanhoDoEfeito);
			tamanhoDoEfeito = tamanhoDoEfeito - 0.1f;
		}
		if (tamanhoDoEfeito < -3) {
			tamanhoDoEfeito = tamanhoDoEfeito + 0.1f;
			transform.localScale = new Vector3 (tamanhoDoEfeito, tamanhoDoEfeito, tamanhoDoEfeito);

		}
	}
}
