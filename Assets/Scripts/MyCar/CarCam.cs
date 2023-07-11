using UnityEngine;

public class CarCam : MonoBehaviour
{
    Transform rootNode;
    Transform carCam;
    Transform car;
    Rigidbody carPhysics;

    [Tooltip("Ak rýchlosť auta je menšia, potom sa kamera predvolene pozerá dopredu")]
    public float rotationThreshold = 1f;
    
    [Tooltip("Ako blízko kamera sleduje pozíciu auta. Čím menšia hodnota, tým viac bude kamera zaostávať za autom.")]
    public float cameraStickiness = 10.0f;
    
    [Tooltip("Ako veľmi sa kamera zhoduje s vektorom rýchlosti vozidla. Čím je hodnota nižšia, tým je pohyb kamery plynulejší.")]
    public float cameraRotationSpeed = 5.0f;

    void Awake()
    {
        carCam = Camera.main.GetComponent<Transform>();
        rootNode = GetComponent<Transform>();
        car = rootNode.parent.GetComponent<Transform>();
        carPhysics = car.GetComponent<Rigidbody>();
    }

    void Start()
    {
        rootNode.parent = null;
    }

    void FixedUpdate()
    {
        Quaternion look;

        // Presunie kameru tak aby sa zhodovala s pozíciou auta
        rootNode.position = Vector3.Lerp(rootNode.position, car.position, cameraStickiness * Time.fixedDeltaTime);

        // Ak sa kamera nehýbe (čiže auto), tak nastaví defaultnú hodnotu.
        if (carPhysics.velocity.magnitude < rotationThreshold)
            look = Quaternion.LookRotation(car.forward);
        else
            look = Quaternion.LookRotation(carPhysics.velocity.normalized);
        
        // Otáča kameru
        look = Quaternion.Slerp(rootNode.rotation, look, cameraRotationSpeed * Time.fixedDeltaTime);                
        rootNode.rotation = look;
    }
}