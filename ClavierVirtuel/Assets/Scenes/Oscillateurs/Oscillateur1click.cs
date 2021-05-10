using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Oscillateur1click : MonoBehaviour
{
    void OnMouseDown()
    {
        VariableOscillo.variable = 1;
        Debug.Log(VariableOscillo.variable); ;
    }

}