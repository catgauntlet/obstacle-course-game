using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlateController : MonoBehaviour
{
    [SerializeField] private ParticleSystem particicleSystem;
    [SerializeField] private Rigidbody gameFloorRigidBody;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            particicleSystem.Play();
            gameFloorRigidBody.isKinematic = false;
        }
    }
}
