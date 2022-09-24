using UnityEngine;

public class SphereDataTransmitter : MonoBehaviour
{

    [SerializeField] private SphereInputController sphereInputController;
    [SerializeField] private SphereColorController sphereColorController;



    public Vector2 SphereInputVector()
    {
        return sphereInputController.sphereInput;
    }



    public void SetMaterialColor(GameObject _gameobject)
    {
        sphereColorController.SetMaterialColor(_gameobject);
    }
}
