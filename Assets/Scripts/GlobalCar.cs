using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
   

        public static int CarType; //1 - zidan, 2 - tiger, 3 - cobra, 4 - cobrablue ,5 - scathe, 6- kailoq
        public GameObject TrackWindow;
        public GameObject CarWindow;
    public void ZidanCar()
        {
            CarType = 1;
            TrackWindow.SetActive(true);
            CarWindow.SetActive(false);
    }

        public void TigerCar()
        {
            CarType = 2;
            TrackWindow.SetActive(true);
            CarWindow.SetActive(false);
    }

        public void CobraCar()
        {
            CarType = 3;
            TrackWindow.SetActive(true);
            CarWindow.SetActive(false);
         }

        public void CobraCarBlue()
        {
            CarType = 4;
            TrackWindow.SetActive(true);
            CarWindow.SetActive(false);
        }
        public void Scathe()
        {
            CarType = 5;
            TrackWindow.SetActive(true);
            CarWindow.SetActive(false);
        }

        public void Kailoq()
        {
            CarType = 6;
            TrackWindow.SetActive(true);
            CarWindow.SetActive(false);
        }

}
