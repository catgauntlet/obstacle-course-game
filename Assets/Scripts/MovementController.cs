using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0f;

    [SerializeField] private GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerMovement();
    }

    void UpdatePlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        this.transform.Translate(xValue, 0f, zValue);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag != "Hit")
        {
            collision.collider.gameObject.tag = "Hit";
            gameManager.IncreaseScore();
        }
    }
}

