using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour
{
    public int cobraSelect;
    public int supraSelect;
    public int zidanSelect;
    public int cobraGTSelect;
    public int kailoqSelect;
    public GameObject BuyCobraCar;
    public GameObject BuySupraCar;
    public GameObject BuyZidanCar;
    public GameObject BuyCobraGTCar;
    public GameObject BuyKailoqCar;
    void Start()
    {
        cobraSelect = PlayerPrefs.GetInt("CobraBought");
        if (cobraSelect == 100)
        {
            BuyCobraCar.SetActive(false);
        }
        supraSelect = PlayerPrefs.GetInt("SupraBought");
        if (supraSelect == 100)
        {
            BuySupraCar.SetActive(false);
        }
        zidanSelect = PlayerPrefs.GetInt("ZidanBought");
        if (zidanSelect == 100)
        {
            BuyZidanCar.SetActive(false);
        }
        cobraGTSelect = PlayerPrefs.GetInt("CobraGTBought");
        if (cobraGTSelect == 100)
        {
            BuyCobraGTCar.SetActive(false);
        }
        kailoqSelect = PlayerPrefs.GetInt("KailoqBought");
        if (kailoqSelect == 100)
        {
           BuyKailoqCar.SetActive(false);
        }
    }


}
