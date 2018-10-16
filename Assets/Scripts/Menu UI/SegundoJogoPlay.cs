using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SegundoJogoPlay : MonoBehaviour
{
    public Camera cameraPrincipal;
    public bool? animacaoCamera;

    void Update()
    {
        if (animacaoCamera == true)
        {
            SceneManager.LoadScene(4);
            //if (cameraPrincipal.transform.eulerAngles.y > -5)
            //{
            //    cameraPrincipal.transform.Rotate(5 * Time.deltaTime, 70 * Time.deltaTime, 0);
            //}
            //if (cameraPrincipal.transform.position.z < -10)
            //{
            //    cameraPrincipal.transform.Translate(0, 3 * Time.deltaTime, 20 * Time.deltaTime);
            //}
            //else
            //{
            //    SceneManager.LoadScene(4);
            //}
        }
        
    }
    void OnMouseDown() {
        print("play2");
        animacaoCamera = true;
    }

}
