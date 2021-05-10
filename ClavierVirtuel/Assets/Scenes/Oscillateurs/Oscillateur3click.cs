using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillateur3click : MonoBehaviour
{
    void OnMouseDown()
    {
        VariableOscillo.variable = 3;
        Debug.Log(VariableOscillo.variable); ;
    }
}
