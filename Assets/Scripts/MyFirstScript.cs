using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     4 varaibles whit the player information
    */
    // This variables saves the player´s age
    public int playerAge = 33;
    // This variables saves the player´s name
    public string playerName = "Luis";
    // This variables saves the player´s speed
    private float playerSpeed = 3.125f;
    // This variables saves if the payer has lost
    [SerializeField]
    private bool gameOver = false;
}
