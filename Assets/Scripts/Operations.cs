using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
     public int x = 7;
     public float y = 4;
     public int z = 4;
     private float result;

    /*private void Start()
    {
        result = x + y;
        Debug.Log(string.Format("Sum: {0} + {1} = {2}", x, y, result));
        result = x - y;
        Debug.Log(string.Format("Subtractions: {0} - {1} = {2}", x, y, result));
        result = x * y;
        Debug.Log(string.Format("Product: {0} * {1} = {2}", x, y, result));
        result = x / y;
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, result));
        result = x % z;
        Debug.Log(string.Format("Module: {0} % {1} = {2}", x, z, result));

    }*/

    /* public int x = 10;
     public int y = 4;
    
    private bool areEqual;
   
    public string name1 = "Eustaquio";
    public string name2 = "Caledonio";
    private bool areDifferent;

    public float x = 2.0f;
    public float y = 0.5f;
    private bool isGreater;

    public bool isRaining;
    public float number;

    The variable wheels saves the number of the vehicle
    [SerializeField]
    private int wheels = 4;


    private void Start()
    {
        areEqual = x == y;
        Debug.Log(areEqual);

        areDifferent = name1 != name2;
        Debug.Log(areDifferent);

        isGreater = x > y;
        Debug.Log(isGreater);

        if (isRaining == true)
        {
            Debug.Log("Recuerda coger el paraguas para no mojarte");
        }
        if(number > 0)
        {
            Debug.Log($"El n�mero {number} es positivo");
        }
        else
        {
            Debug.Log("El n�mero {number} es negativo o cero");
        }
    }

      //Debug.Log(string.Format("Hola {0}, tienes ruedas de repuesto aparte de las {1} que tienes?", name, wheels));
        if(isOn == false)
        {
            //Debug.Log(string.Format("{0} est� encendido", name));
            Debug.Log(string.Format("{0} est� apagado", name));
        }
    else if(sound != "") 
        {
            //Debug.Log(string.Format("{0} est� apagado", name));
            Debug.Log(string.Format("{0} est� encendido y dice {1}", name, sound));
        }
        else
        {
            Debug.Log(string.Format("{0} est� en marcha", name));
        }
    */
    public float num1 = 7;
    public float num2 = 4;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Calculator(x, y);
        }
    }
    private void Calculator (float Num1, float Num2)
    {
        Debug.Log($"Sum:{num1} + {num2} = {num1 + num2}");
        Debug.Log($"Subtracion:{num1} - {num2} = {num1 - num2}");
        Debug.Log($"Product:{num1} * {num2} = {num1 * num2}");
        Debug.Log($"Division:{num1} / {num2} = {num1 / num2}");
    }

}
