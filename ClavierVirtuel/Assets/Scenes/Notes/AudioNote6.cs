using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote6 : MonoBehaviour
{
   public AudioSource Note6;

    void Update()
    {
        if (Capteur.capteur == "0000 6000")
        {

            Note6.Play();
        }
    }
}
