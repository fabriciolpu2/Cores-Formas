using UnityEngine;
using System.Collections;

public class BotaoBrincar : MonoBehaviour {

	//Variável para guardar o objeto "Luz do Quarto". Acesso público.
	public Light luzDoQuarto;

	public GameObject botaoBrincar;
	public Camera cameraPrincipal;

	public GameObject ScriptLuzDoQuarto;

	public GameObject animacaoTitulo;

	private float i;
	private bool? estadoIluminacaoEsquerdo;
    
    // Mudar intensidade do brilho nos objs
	public GameObject scriptMudarIntensidadeHDR0101;
	public GameObject scriptMudarIntensidadeHDR0102;
	public GameObject scriptMudarIntensidadeHDR0103;
    public GameObject scriptMudarIntensidadeHDR0201;
    

    private bool? clickBtnBrincar;

    void OnMouseDown(){		
		animacaoTitulo.GetComponent<Animator> ().Play ("TituloSaindoDaTela");
		botaoBrincar.GetComponent<Animator> ().Play ("BotaoBrincarSaindoDaTela");
        clickBtnBrincar = true;
        scriptMudarIntensidadeHDR0101.GetComponent<MudarIntensidadeHDR> ().enabled = true;
		scriptMudarIntensidadeHDR0102.GetComponent<MudarIntensidadeHDR> ().enabled = true;
		scriptMudarIntensidadeHDR0103.GetComponent<MudarIntensidadeHDR> ().enabled = true;
        scriptMudarIntensidadeHDR0201.GetComponent<MudarIntensidadeHDR> ().enabled = true;

    }
    void Update()
    {
        // Verifica clik no botao brincar e dispara animação da camara.
        if(clickBtnBrincar == true)
        {
            // Animacao Camera
            if (cameraPrincipal.transform.position.z < -20)
            {
                cameraPrincipal.transform.Translate(0, 0, 10 * Time.deltaTime);
            }
            //Incrementa a intensidade da luz a cada ciclo do update.
            if (luzDoQuarto.intensity < 3.2)
            {
                luzDoQuarto.intensity = luzDoQuarto.intensity + 0.5f;
            }
        }
    }

}