using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class VariableOscillo : MonoBehaviour
{
    public static int variable;
    public int oscillateur;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        oscillateur = variable;
    }
}
