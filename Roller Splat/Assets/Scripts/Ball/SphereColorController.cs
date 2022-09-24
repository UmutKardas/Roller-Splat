using UnityEngine;

public class SphereColorController : MonoBehaviour
{

    [SerializeField] private Material redMaterial;



    public void SetMaterialColor(GameObject _gameobject)
    {
        _gameobject.GetComponent<MeshRenderer>().material = redMaterial;
    }
}
