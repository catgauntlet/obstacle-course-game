using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBehaviour : MonoBehaviour
{
    Transform transform;

    [SerializeField] private float rotationSpeed = 1.0f;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0));
    }
}
