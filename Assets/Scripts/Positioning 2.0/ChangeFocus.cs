using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFocus : MonoBehaviour
{
    public bool isUsedAI;
    public bool isUsedPlayer;
    public PositionManager master;

    private void OnTriggerEnter(Collider col)
    {
        

        if (col.tag == "PlayerCar" && !isUsedPlayer)
        {
            
            master.currentPointPlayer++;
            if(!GetComponent<LastPointTrigger>())
                {
                isUsedPlayer = true;
                }

        }
        
        if (col.tag == "AICar" && !isUsedAI)
        {
             master.currentPointAI++;
            if (!GetComponent<LastPointTrigger>())
            {
                isUsedAI = true;
            }

        }

        

        
    }
}
