using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonOptions : MonoBehaviour
{
   
    public void PlayGame()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        PlayerPrefs.Save();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.Save();
       
    }


  

 
}
