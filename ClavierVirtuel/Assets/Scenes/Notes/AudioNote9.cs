using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote9 : MonoBehaviour
{
    public AudioSource Note9;

    void Update()
    {
        if (Capteur.capteur == "0000 8800")
        {

            Note9.Play();
        }
    }
}
