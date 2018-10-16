using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoad : MonoBehaviour {

    public GameObject LoadingScreen;
    public Slider slider;
    public int fase;

    public void Start()
    {
        LoadLevel(fase);
    }
    public void LoadLevel(int sceneIndex)
    {
        // AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        //operation.
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            //Debug.Log(progress);
            yield return null;
        }
    }

}
