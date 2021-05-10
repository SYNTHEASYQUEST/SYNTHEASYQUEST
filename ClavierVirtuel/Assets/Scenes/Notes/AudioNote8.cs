using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNote8 : MonoBehaviour
{
   public AudioSource Note8;

    void Update()
    {
        if (Capteur.capteur == "0000 8000")
        {

            Note8.Play();
        }
    }
}
