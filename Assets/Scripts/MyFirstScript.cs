using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     4 varaibles whit the player information
    */
    /*
    public int playerAge = 33;
    // This variables saves the player´s name
    public string playerName = "Luis";
    // This variables saves the player´s speed
    private float playerSpeed = 3.125f;
    // This variables saves if the player has lost
    [SerializeField]
    private bool gameOver = false;
    
    public string  message ="Hello World";
    public int points = 256;
    */
    public Vector3 initialPos = new Vector3(1,1,1);

    private void Start()
    {/*
        Debug.Log(message);
        Debug.Log(points);
        Debug.Log($"Tengo {points} puntos");
        Debug.Log($"Hola {playerName}, tienes {points} puntos");

        Debug.Log(string.Format("Tengo {0} puntos",points));
        Debug.Log(string.Format("Hola {0}, tienes {1} puntos",playerName, points));
        */

        transform.position = initialPos;
    }

}
