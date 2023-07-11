using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockingLevel : MonoBehaviour
{
    public GameObject Button;
    public int respectValue;
    public int respect;

    void Update()
    { 
        respectValue = GlobalCurrency.TotalRespect;
        if (respectValue >= respect)
        {
            Button.GetComponent<Button>().interactable = true;
        }
        else
        if (respectValue <= respect)
        {
            Button.GetComponent<Button>().interactable = false;
        }

    }
}
