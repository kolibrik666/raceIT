using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    [Header("PosSystem")]
    public float playerDistance;
    public GameObject[] points;
    public PositionManager master;

    [Header("Car")]
    public Transform centerOfMass;
    private Rigidbody _rigidbody;
    private Wheel[] wheels;
    public float BrakeTorque = 200000f;
    public float motorTorque = 100f;
    public float maxSteer = 20f;
    public float Steer { get; set; }
    public float Throttle { get; set; }

    public WheelCollider RearRightWheel;
    public WheelCollider RearLeftWheel;

    [Header("Gears")]
    public TMPro.TextMeshProUGUI SpeedText;
    public float currentSpeed;
    public float pitch = 0;
    [Range(0, 3)] public float modifier;

    [Header("Sound")]
    public AudioSource crashSourceTree;
    public AudioSource crashSourceTires;
    public AudioSource crashSourceFence;
    public AudioSource crashSourceConcrete;
    public AudioSource crashSourceSign;


    void Start()
    {
        wheels = GetComponentsInChildren<Wheel>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centerOfMass.localPosition;
    }
    public void FindPosition()
    {
        playerDistance = Vector3.Distance(points[master.currentPointPlayer].transform.position, this.transform.position);
    }
    void Update()
    {
        FindPosition();

        Steer = GameManager.Instance.InputController.SteerInput;
        Throttle = GameManager.Instance.InputController.ThrottleInput;
        currentSpeed = _rigidbody.velocity.magnitude * 3.6f; ;  // násobime aby sme to mali v km/h
       
        UpdateGears();
       

        SpeedText.GetComponent<TMPro.TextMeshProUGUI>().text = currentSpeed.ToString("F0");
       
        foreach (var wheel in wheels)
        {
            wheel.SteerAngle = Steer * maxSteer;
            wheel.Torque = Throttle * motorTorque;
           
        }

    }
    public void FixedUpdate()
    {
         if (Input.GetKey(KeyCode.Space))
        {
            RearRightWheel.brakeTorque = BrakeTorque;
            RearLeftWheel.brakeTorque = BrakeTorque;

        }
        else //Remove handbrake
        {
            RearRightWheel.brakeTorque = 0;
            RearLeftWheel.brakeTorque = 0;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trees"))
        {
            if (currentSpeed <= 40 )
            {
                crashSourceTree.volume = 0.1f;
                crashSourceTree.Play();
            }
            if (currentSpeed >= 40)
            {
                crashSourceTree.volume = 0.4f;
                crashSourceTree.Play();
            }
           
        }

        if (collision.gameObject.CompareTag("Tires"))
        { 
            if (currentSpeed <= 40)
            {
                crashSourceTires.volume = 0.1f;
                crashSourceTires.Play();
            }
            if (currentSpeed >= 40)
            {
                crashSourceTires.volume = 0.4f;
                crashSourceTires.Play();
            }
    
        }

        
        if (collision.gameObject.CompareTag("Wood"))
        {   
            
           
                if (currentSpeed <= 40)
                {
                    crashSourceFence.volume = 0.5f;
                    crashSourceFence.Play();
                }
                if (currentSpeed >= 40)
                {
                    crashSourceFence.volume = 1f;
                    crashSourceFence.Play();
                }
            
        }

        if (collision.gameObject.CompareTag("Concrete"))
        {


            if (currentSpeed <= 40)
            {
                crashSourceConcrete.volume = 0.5f;
                crashSourceConcrete.Play();
            }
            if (currentSpeed >= 40)
            {
                crashSourceConcrete.volume = 1f;
                crashSourceConcrete.Play();
            }

        }

        if (collision.gameObject.CompareTag("Sign"))
        {


            if (currentSpeed <= 40)
            {
                crashSourceSign.volume = 0.5f;
                crashSourceSign.Play();
            }
            if (currentSpeed >= 40)
            {
                crashSourceSign.volume = 1f;
                crashSourceSign.Play();
            }

        }

    }
    void UpdateGears()
    {

        if (currentSpeed <= 40)
         {
             
             pitch = 1.0f;
         }

         if (currentSpeed >= 70)
         {
           
             pitch = 1.5f;
         }

         if (currentSpeed >= 100)
         {
             pitch = 2.0f;
         }

        if (currentSpeed >= 130)
        {
            pitch = 2.5f;
        }

        if (currentSpeed >= 170)
        {
            pitch = 3.5f;
        }

        GetComponent<AudioSource>().pitch = currentSpeed / pitch * modifier *.01f;

    }
}
