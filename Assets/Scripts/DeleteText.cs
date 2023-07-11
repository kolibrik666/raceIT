using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteText : MonoBehaviour
{
    public GameObject Reqs;
   
    public int respectValue;
    public int respect;

    void Update()
    {
        respectValue = GlobalCurrency.TotalRespect;
        if (respectValue >= respect)
        {
            Reqs.SetActive(false);
           
        }
    }
}
