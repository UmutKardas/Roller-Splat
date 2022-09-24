using UnityEngine;

public class SphereInputController : MonoBehaviour
{

    [HideInInspector] public Vector2 sphereInput;



    void Update()
    {
        SetSphereInput();
    }



    private void SetSphereInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sphereInput = Camera.main.WorldToViewportPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        }
    }
}
