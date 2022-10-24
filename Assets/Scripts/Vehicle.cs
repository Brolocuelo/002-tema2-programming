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

    [SerializeField]
    private bool isOn;

    public string sound;

    private void Start()
    {
        Debug.Log(string.Format("Hola {0}, tienes ruedas de repuesto aparte de las {1} que tienes?", name, wheels));
        if(isOn == false)
        {
            //Debug.Log(string.Format("{0} está encendido", name));
            Debug.Log(string.Format("{0} está apagado", name));
        }
        else if(sound != "") 
        {
            //Debug.Log(string.Format("{0} está apagado", name));
            Debug.Log(string.Format("{0} está encendido y dice {1}", name, sound));
        }
        else
        {
            Debug.Log(string.Format("{0} está en marcha", name));
        }
    }
    
}
