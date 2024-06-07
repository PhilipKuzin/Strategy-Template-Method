using UnityEngine;

public class Sphere : MonoBehaviour
{
    [field: SerializeField] public SphereColor Color { get; private set; }

    public void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
