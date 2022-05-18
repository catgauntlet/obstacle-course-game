using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropLogic : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rigidBody;

    [SerializeField] private float dropStartTime = 0f;

    private bool isDropping = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropStartTime && !isDropping)
        {
            isDropping = true;
            renderer.enabled = true;
            rigidBody.isKinematic = false;
        }
    }
}
