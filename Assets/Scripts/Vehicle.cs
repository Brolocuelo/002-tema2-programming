using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //The variable wheels saves the number of the vehicle
    [SerializeField]
    private int wheels = 4;
    [SerializeField]
    private string name;

    public void Start()
    {
        Debug.Log(string.Format("Hola {0}, tienes ruedas de repuesto aparte de las {1} que tienes", name, wheels));
    }
}
