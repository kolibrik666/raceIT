using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject ZidanCar;//1
    public GameObject TigerCar;//2
    public GameObject CobraCar;//3
    public GameObject CobraCarBlue;//4
    public GameObject ScatheRS;//5
    public GameObject Kailoq;//6
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            ZidanCar.SetActive(true);
        }

        if (CarImport == 2)
        {
            TigerCar.SetActive(true);
        }

        if (CarImport == 3)
        {
            CobraCar.SetActive(true);
        }

        if (CarImport == 4)
        {
            CobraCarBlue.SetActive(true);
        }
        if (CarImport == 5)
        {
            ScatheRS.SetActive(true);
        }
        if (CarImport == 6)
        {
            Kailoq.SetActive(true);
        }
    }

}
