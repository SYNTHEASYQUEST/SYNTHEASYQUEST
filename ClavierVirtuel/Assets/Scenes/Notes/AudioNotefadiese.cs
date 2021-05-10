using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNotefadiese : MonoBehaviour
{
    public AudioSource Note10;
    
    void Update()
    {
        if (Capteur.capteur == "0001 0000")
        {

            Note10.Play();
        }
    }
}
