using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        PrintGameInstructions();
    }

    private void PrintGameInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move Cubey with the arrow keys or WASD keys");
        Debug.Log("Don't hit the walls!");
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Score increased: " + score);
    }
}
