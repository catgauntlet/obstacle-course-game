using UnityEngine;

public class WallCollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material.color = new Color(1, 0, 0);
    }
}
