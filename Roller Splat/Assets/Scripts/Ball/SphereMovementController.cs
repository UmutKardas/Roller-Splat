using UnityEngine;

public class SphereMovementController : MonoBehaviour
{

    [SerializeField] private SphereDataTransmitter sphereDataTransmitter;
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float movementSpeed;



    void FixedUpdate()
    {
        SetSphereMovement();
    }



    private void SetSphereMovement()
    {
        if (sphereDataTransmitter.SphereInputVector().x < 0.1f && sphereDataTransmitter.SphereInputVector().x >= 0)
        {
            sphereRigidbody.velocity = Vector3.forward * movementSpeed * Time.fixedDeltaTime;
        }

        else if (sphereDataTransmitter.SphereInputVector().x < -1.2f)
        {
            sphereRigidbody.velocity = Vector3.back * movementSpeed * Time.fixedDeltaTime;
        }

        else if (sphereDataTransmitter.SphereInputVector().x >= -1.2f && sphereDataTransmitter.SphereInputVector().x < 0)
        {
            sphereRigidbody.velocity = Vector3.right * movementSpeed * Time.fixedDeltaTime;
        }

        else if (sphereDataTransmitter.SphereInputVector().x > 0.1f)
        {
            sphereRigidbody.velocity = Vector3.left * movementSpeed * Time.fixedDeltaTime;
        }
    }
}
