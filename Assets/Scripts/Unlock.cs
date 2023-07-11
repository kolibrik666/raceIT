using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlock : MonoBehaviour
{

    public GameObject Button;
    public int moneyValue;
    public int price;
    public int respectValue;
    public int respect;

    void Update()
    {
        moneyValue = GlobalCurrency.TotalMoney;
        respectValue = GlobalCurrency.TotalRespect;
        if ((moneyValue >= price) && (respectValue >= respect))
        {
            Button.GetComponent<Button>().interactable = true;
        }
        else
        if ((respectValue <= respect) && (moneyValue <= price))
        {
            Button.GetComponent<Button>().interactable = false;
        }
      
    }

    public void UnlockCar()
    {
        Button.SetActive(false);
        moneyValue -= 7500;
        GlobalCurrency.TotalMoney -= 7500;
      
        PlayerPrefs.SetInt("SavedMoney",GlobalCurrency.TotalMoney);
        PlayerPrefs.SetInt("CobraBought", 100);
    }

    public void UnlockModel4Car()
    {
        Button.SetActive(false);
        moneyValue -= 15000;
        GlobalCurrency.TotalMoney -= 15000;

        PlayerPrefs.SetInt("SavedMoney", GlobalCurrency.TotalMoney);
        PlayerPrefs.SetInt("SupraBought", 100);
    }
    public void UnlockZidanCar()
    {
        Button.SetActive(false);
        moneyValue -= 30000;
        GlobalCurrency.TotalMoney -= 30000;

        PlayerPrefs.SetInt("SavedMoney", GlobalCurrency.TotalMoney);
        PlayerPrefs.SetInt("ZidanBought", 100);
    }
    public void UnlockCobraGTCar()
    {
        Button.SetActive(false);
        moneyValue -= 50000;
        GlobalCurrency.TotalMoney -= 50000;

        PlayerPrefs.SetInt("SavedMoney", GlobalCurrency.TotalMoney);
        PlayerPrefs.SetInt("CobraGTBought", 100);
    }
    public void UnlockKailoqCar()
    {
        Button.SetActive(false);
        moneyValue -= 75000;
        GlobalCurrency.TotalMoney -= 75000;

        PlayerPrefs.SetInt("SavedMoney", GlobalCurrency.TotalMoney);
        PlayerPrefs.SetInt("KailoqBought", 100);
    }
}
