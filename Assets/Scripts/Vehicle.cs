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

    [SerializeField]
    private float gasoline;

    private void Start()
    {
        if(isOn == true && gasoline < 10)
        {
                Debug.Log(string.Format("¡A {} le queda poca gasolina!", name));
        }
    }
    
}
