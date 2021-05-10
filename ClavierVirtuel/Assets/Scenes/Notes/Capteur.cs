using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Capteur : MonoBehaviour
{
    public static string capteur;

    // Start is called before the first frame update
    void Start()
    {
        //capteur = File.ReadAllText("C:/Users/Cokila/ENSEA/PROJET/UDPCode/UDPTEST/variable.txt");
    }

    // Update is called once per frame
    void Update()
    {
        //capteur = File.ReadAllText("C:/Users/Cokila/ENSEA/PROJET/UDPCode/UDPTEST/variable.txt");
        capteur = "0000 1000";
        Debug.Log("capteur=" + capteur);
    }
}