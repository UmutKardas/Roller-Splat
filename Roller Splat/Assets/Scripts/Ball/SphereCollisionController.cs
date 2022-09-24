using UnityEngine;
using Kardas;

public class SphereCollisionController : MonoBehaviour
{

    [SerializeField] private SphereDataTransmitter sphereDataTransmitter;
    [SerializeField] private GameManager gameManager;



    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag(Tag.GROUND))
        {
            sphereDataTransmitter.SetMaterialColor(other.gameObject);
            gameManager.SetGroundList(other.gameObject);
        }
    }
}
