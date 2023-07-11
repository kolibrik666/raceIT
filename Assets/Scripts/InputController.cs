using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public string inputSteerAxis = "Horizontal";
    public string inputThrottleAxis = "Vertical";
    


    public float ThrottleInput { get; private set; }
    public float SteerInput { get; private set; }

 

    // Update is called once per frame
    void Update()
    {
        SteerInput = Input.GetAxis(inputSteerAxis); //získa hodnoty z toho ako zatáčame vozidlo pomocou šípok vľavo, vpravo
        ThrottleInput = Input.GetAxis(inputThrottleAxis); //získa hodnoty z toho ako pridávame plyn pomocou šípky vpred
        
    }


}

