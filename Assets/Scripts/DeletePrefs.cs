using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePrefs : MonoBehaviour
{
   public void Delete ()
    { 
        PlayerPrefs.SetInt("CobraBought", 0);
        PlayerPrefs.SetInt("SupraBought", 0);
        PlayerPrefs.SetInt("ZidanBought", 0);
        PlayerPrefs.SetInt("CobraGTBought", 0);
        PlayerPrefs.SetInt("KailoqBought", 0);
        PlayerPrefs.SetInt("SavedMoney", 0);
        PlayerPrefs.SetInt("SavedRespect",0);



    }
}
