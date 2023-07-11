using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityStandardAssets.Vehicles.Car;

public class PositionManager : MonoBehaviour
{
    public float[] car_positions;
    public GameObject Player;
    public float PlayerPosition;
    public GameObject[] AI;
    public int currentPos;
   

    public int lapAI;
    public int lapPlayer;
    public int currentPointAI;
    public int currentPointPlayer;

    public TMPro.TextMeshProUGUI posText;

   

    void Update()
    {
        FindPlayer();

        if (lapPlayer == lapAI || lapAI == lapPlayer)
        {
            if (currentPointPlayer == currentPointAI || currentPointAI == currentPointPlayer)
            {
                PositionCalc();
            }
            

        }
        
        posText.text = currentPos.ToString();

        
    }
    public void FindPlayer()
    {
        Player = GameObject.FindGameObjectWithTag("PlayerCar");
    }

    public void PositionCalc()
    {
        car_positions[0] = Player.GetComponent<Car>().playerDistance;
        car_positions[1] = AI[0].GetComponent<CarAIControl>().aiDistance;
       

        PlayerPosition = Player.GetComponent<Car>().playerDistance;

        Array.Sort(car_positions);

        int x = Array.IndexOf(car_positions, PlayerPosition);

        switch (x)
        {

            case 0:
         currentPos = 1;
         break;
            case 1:
         currentPos = 2;
         break;
            


        }
    }
}
