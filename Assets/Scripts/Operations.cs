using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public int x = 7;
    public float y = 4;
    public int z = 4;
    private float result;

    private void Start()
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
    }
  
 
}
