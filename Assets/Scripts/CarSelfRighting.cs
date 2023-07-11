using System.Collections;
using UnityEngine;

public class CarSelfRighting : MonoBehaviour
{
    [SerializeField] private float _WaitTime = 3f;           // za aký čas sa auto vráti naspäť na svoje miesto
    [SerializeField] private float _VelocitySpeed = 1f;      // rýchlosť pri ktorej sa auta považuje za stacionárne

    private float _LastOkTime;                               // naposledy čo bolo auto v poriadku
    private Rigidbody _rigidbody;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
       // skontroluje že či sa auto neprevrátilo
        if (transform.up.y > 0f || _rigidbody.velocity.magnitude > _VelocitySpeed)
        {
            _LastOkTime = Time.time;
        }

        if (Time.time > _LastOkTime + _WaitTime)
        {
            RightCar();
        }
    }


    // ak je auto prevrátené tak ho otočí späť
    private void RightCar()
    {
        transform.position += Vector3.up;                                       // otočí auto spraávne a zdvihne ho zo zeme trochu
        transform.rotation = Quaternion.LookRotation(transform.forward);
    }
}
