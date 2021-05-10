using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillateur2click : MonoBehaviour
{
    void OnMouseDown()
    {
        VariableOscillo.variable = 2;
        Debug.Log(VariableOscillo.variable); ;
    }
}
