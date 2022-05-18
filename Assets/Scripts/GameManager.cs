using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintGameInstructions();
    }

    void PrintGameInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move Cubey with the arrow keys or WASD keys");
        Debug.Log("Don't hit the walls!");
    }
}
