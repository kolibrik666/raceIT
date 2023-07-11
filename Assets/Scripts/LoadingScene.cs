using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public GameObject menuScreen;
    public GameObject levelMusic;
    public Sprite[] backgrounds;
    public Image backgroundImage;

    public void LoadLevel(int sceneIndex)
    {
        levelMusic.SetActive(false);
        backgroundImage.sprite = backgrounds[Random.Range(0, backgrounds.Length)];
        StartCoroutine(LoadAsynch(sceneIndex));
       
    }

    IEnumerator LoadAsynch (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        menuScreen.SetActive(false);
        loadingScreen.SetActive(true);
        Time.timeScale = 1f;
        PlayerPrefs.Save();

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}

