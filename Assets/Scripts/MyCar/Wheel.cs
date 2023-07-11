using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{

    public bool steer;
    public bool invertSteer;
    public bool power;          //ktoré koleso akú bude mať úlohu. V inspectore si môžeme nastaviť pre každé koleso
   

    public float SteerAngle { get; set; }
    public float Torque { get; set; }

    private WheelCollider wheelCollider;
    private Transform wheelTransform;

    void Start()
    {
        wheelCollider = GetComponentInChildren<WheelCollider>();
        wheelTransform = GetComponentInChildren<MeshRenderer>().GetComponent<Transform>();
    }

   
    void Update()
    {
        wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
       
    }

    private void FixedUpdate()
    {
        if (steer)
        {
            wheelCollider.steerAngle = SteerAngle * (invertSteer ? -1 : 1);
        }

        if (power)
        {
            wheelCollider.motorTorque = Torque;
        }
   
    }
  
}
