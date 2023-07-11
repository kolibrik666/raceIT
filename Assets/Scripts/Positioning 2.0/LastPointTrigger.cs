using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPointTrigger : MonoBehaviour
{
    public ChangeFocus slave;
    public PositionManager master;
    public GameObject[] points2;
    public bool isUsedAI;
    public bool isUsedPlayer;
    public ChangeFocus lastPoint;

   


    private void OnTriggerEnter(Collider col)
    {
        if(lastPoint.isUsedPlayer == true)
        { 
             if (col.tag == "PlayerCar" )
                {
               isUsedPlayer = false;
                foreach (GameObject LastPointTrigger in points2)
                {
                    LastPointTrigger.GetComponent<ChangeFocus>().isUsedPlayer = false;
                }

                master.lapPlayer++;         
                master.currentPointPlayer = -1;
                    
             }
        }
        if (lastPoint.isUsedAI == true)
        {
                if (col.tag == "AICar" )
            {
                isUsedAI = false;
                foreach (GameObject LastPointTrigger in points2)
                {
                    LastPointTrigger.GetComponent<ChangeFocus>().isUsedAI = false;
                }

                master.lapAI++;
                master.currentPointAI = -1;
            }

        }

    }
}
