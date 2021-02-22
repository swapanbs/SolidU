using UnityEngine;
public class MouseScreenRayProvider:MonoBehaviour,IRayProvider
{
    public Ray RayCreate()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }
}