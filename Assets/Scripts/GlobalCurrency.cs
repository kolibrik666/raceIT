using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCurrency: MonoBehaviour
{
    public int MoneyValue;
    public static int TotalMoney;
    public GameObject MoneyDisplay;

    public int RespectValue;
    public static int TotalRespect;
    public GameObject RespectDisplay;

    void Start()
    {
        TotalMoney = PlayerPrefs.GetInt("SavedMoney");
        TotalRespect = PlayerPrefs.GetInt("SavedRespect");
    }


    void Update()
    {
        MoneyValue = TotalMoney;
        MoneyDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + MoneyValue;

        RespectValue = TotalRespect;
        RespectDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + RespectValue;
    }
}
